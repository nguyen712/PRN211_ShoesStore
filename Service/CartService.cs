using Microsoft.AspNetCore.Http;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace PRN211_ShoesStore.Service
{
    public class CartService : ICartService
    {
        IRepository<CartItem> _cartItemRepository;
        IRepository<Shoes> _shoesRepository;
        IRepository<SpecificallyShoes> _specificallyShoes;
		IRepository<CartItemDetails> _cartItemDetailsRepository;
		//constructor
		public CartService(IRepository<CartItem> cartItemRepository, IRepository<Shoes> shoesRepository, IRepository<SpecificallyShoes> specificallyShoes, IRepository<CartItemDetails> cartItemDetailsRepository)
		{
			_cartItemRepository = cartItemRepository;
			_shoesRepository = shoesRepository;
			_specificallyShoes = specificallyShoes;
			_cartItemDetailsRepository = cartItemDetailsRepository;
		}

		public IEnumerable<CartItem> GetCartItem()
        {

            return _cartItemRepository.GetData();
        }

        public IEnumerable<CartItemDetails> GetCartItemDetails()
        {
            List<CartItemDetails> cartItems = _cartItemDetailsRepository.GetData().ToList();
            List<Shoes> shoesList = _shoesRepository.GetData().ToList();
            List<Shoes> specificallyShoesList = _shoesRepository.GetData().ToList();
            List<CartItem> carts = _cartItemRepository.GetData().ToList();
            var res = from cartItem in cartItems
                      join shoes in shoesList on cartItem.shoesId equals shoes.id
                      join product in specificallyShoesList on shoes.id equals product.id
                      join cart in carts on cartItem.cartItemId equals cart.Id
                      select new CartItemDetails(cartItem.Id, cart, shoes, cartItem.ShoesName, shoes.image, cartItem.Quantity, cartItem.Price);

            
            return res;
        }

        public CartItem GetCartItemById(int CartItemId)
        {
            return _cartItemRepository.GetById(CartItemId);
        }

        public IEnumerable<CartItem> GetCartItemByName(string CartItemname)
        {
            /*return _cartItemRepository.GetData(s => s.SpecificallyShoesnName == CartItemname);*/
            return null;
        }

        public bool UpdateCartItem(int cartItemId, int cartId, int quantity, int shoesId)
        {
            CartItem cart = _cartItemRepository.GetById(cartId);
            CartItemDetails cartItem = _cartItemDetailsRepository.GetById(cartItemId);
            Shoes shoes = _shoesRepository.GetById(cartItem.shoesId);
            if (quantity > shoes.quantity)
            {
                return false;
            }
            cartItem.Quantity = quantity;
            cartItem.Price = quantity * shoes.price;
            var updateCartItem =_cartItemDetailsRepository.Update(cartItem);
            if (updateCartItem)
            {
                List<CartItemDetails> cartDetails = _cartItemDetailsRepository.GetData().Where(c => c.cartItemId == cartId).ToList();
                decimal total = 0;
                    foreach (var item in cartDetails)
                    {
                        total += item.Price;
                    }
                    cart.Price = total;
            }
            return _cartItemRepository.Update(cart);
        }

        public void addToCartItem(int UserId, int specificallyShoesId, decimal price)
        {
            Shoes specificallyShoes = _shoesRepository.GetById(specificallyShoesId);
            CartItem cart = new CartItem();
            CartItemDetails cartItemDetails = new CartItemDetails();
            CartItem existCart = _cartItemRepository.GetData().ToList().Where(c => c.userId == UserId).FirstOrDefault();
            List<CartItemDetails> productsCartIsExisted = _cartItemDetailsRepository.GetData().ToList().Where(c => c.cartItemId == existCart.Id).ToList();
            if (existCart != null)
            {

                foreach (var productCartIsExisted in productsCartIsExisted)
                {
                    if (productCartIsExisted.shoesId == specificallyShoesId)
                    {
                        int quantity = ++productCartIsExisted.Quantity;
                        bool checkQuantity = quantity < specificallyShoes.quantity;
                        if (checkQuantity)
                        {
                            productCartIsExisted.Quantity = quantity;
                            productCartIsExisted.Price = quantity * price;
                            decimal totalPrice = 0;
                            _cartItemDetailsRepository.Update(productCartIsExisted);
                            List<CartItemDetails> cartDetails = _cartItemDetailsRepository.GetData().Where(c => c.cartItemId == existCart.Id).ToList();
                            existCart.Price = 0;
                            if (cartDetails.Count > 1)
                            {
                                foreach (var product in cartDetails)
                                {
                                    totalPrice += product.Price;
                                }
                            }

                            if (cartDetails.Count == 1)
                            {
                                totalPrice = quantity * price;
                            }

                            existCart.Price = totalPrice;
                            _cartItemRepository.Update(existCart);
                            
                            return;
                        }
                        else
                        {
                            throw new Exception("This shoes is sold out");
                        }
                    }
                }
                cartItemDetails.Price = price;
                cartItemDetails.Quantity = 1;
                cartItemDetails.ShoesName = specificallyShoes.name;
                cartItemDetails.ShoesImg = specificallyShoes.image;
                cartItemDetails.shoesId = specificallyShoes.id;
                cartItemDetails.cartItemId = existCart.Id;
                _cartItemDetailsRepository.Insert(cartItemDetails);
                List<CartItemDetails> items = _cartItemDetailsRepository.GetData().Where(c => c.cartItemId == existCart.Id).ToList();
                existCart.Price = 0;
                foreach (var i in items)
                {
                    existCart.Price += i.Price;
                }
                _cartItemRepository.Update(existCart);
                return;
            }
            cart.userId = UserId;
            cart.Price = price;
			bool res = _cartItemRepository.Insert(cart);
            if (res)
            {
                CartItem newCart =_cartItemRepository.GetData().First();
				cartItemDetails.cartItemId = newCart.Id;
				cartItemDetails.Price = price;
				cartItemDetails.Quantity = 1;
				cartItemDetails.ShoesName = specificallyShoes.name;
				cartItemDetails.ShoesImg = specificallyShoes.image;
				cartItemDetails.shoesId = specificallyShoes.id;
				_cartItemDetailsRepository.Insert(cartItemDetails);
			}
		}

        public void DeleteCartItem(int cartItemId, int cartId)
        {
            CartItemDetails cartItem = _cartItemDetailsRepository.GetData().ToList().Where(i => i.Id == cartItemId).FirstOrDefault();
            CartItem cart = _cartItemRepository.GetById(cartId);
            if (cartItem != null)
            {
               _cartItemDetailsRepository.Delete(cartItem);
            }
            
            List<CartItemDetails> list = _cartItemDetailsRepository.GetData().Where(i => i.cartItemId == cartId).ToList();
            decimal price = 0;
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    price+= item.Price;
                }
                cart.Price = price;
                _cartItemRepository.Update(cart);
            }
            if (list.Count() == 0)
            {
                _cartItemRepository.Delete(cart);
            }
        }
    }
}