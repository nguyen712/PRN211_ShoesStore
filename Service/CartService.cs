using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN211_ShoesStore.Service
{
    public class CartService : ICartService
    {
        IRepository<CartItem> _cartItemRepository;
        IRepository<Shoes> _shoesRepository;
        IRepository<SpecificallyShoes> _specificallyShoes;
        //constructor
        public CartService(IRepository<CartItem> cartItemRepository, IRepository<Shoes> shoesRepository, IRepository<SpecificallyShoes> specificallyShoes)
        {
            _cartItemRepository = cartItemRepository;
            _shoesRepository = shoesRepository;
            _specificallyShoes = specificallyShoes;
        }

        public IEnumerable<CartItem> GetCartItem()
        {

            return _cartItemRepository.GetData();
        }

        public IEnumerable<CartItem> GetCartItemDetails()
        {

            List<CartItem> cartItems = _cartItemRepository.GetData().ToList();
            List<Shoes> shoesList = _shoesRepository.GetData().ToList();
            List<SpecificallyShoes> specificallyShoesList = _specificallyShoes.GetData().ToList();



            var res = from cartItem in cartItems
                      join shoes in shoesList on cartItem.SpecificallyShoesId equals shoes.id
                      join product in specificallyShoesList on shoes.id equals product.shoesId
                      select new CartItem(cartItem.Id, cartItem.UserId, cartItem.SpecificallyShoesId, cartItem.SpecificallyShoesnName, shoes.image, cartItem.Quantity, cartItem.Price);

            return res;
        }

        public CartItem GetCartItemById(int CartItemId)
        {
            return _cartItemRepository.GetById(CartItemId);
        }

        public IEnumerable<CartItem> GetCartItemByName(string CartItemname)
        {
            return _cartItemRepository.GetData(s => s.SpecificallyShoesnName == CartItemname);
        }

        public bool UpdateCartItem(CartItem CartItem)
        {
            CartItem cart = _cartItemRepository.GetById(CartItem.Id);
            SpecificallyShoes specificallyShoes = _specificallyShoes.GetById(CartItem.SpecificallyShoesId);
            if (CartItem.Quantity > specificallyShoes.quantity)
            {
                return false;
            }
            cart.Quantity = CartItem.Quantity;
            cart.Price = CartItem.Price * CartItem.Quantity;
            return _cartItemRepository.Update(cart);
        }

        public void addToCartItem(int UserId, int specificallyShoesId, int quantity, decimal price)
        {
            SpecificallyShoes specificallyShoes = _specificallyShoes.GetById(specificallyShoesId);


            if (quantity > specificallyShoes.quantity)
            {
                throw new Exception("This shoes is sold out!!!");
            }
            CartItem cart = new CartItem();
            cart.UserId = UserId;
            cart.SpecificallyShoesId = specificallyShoes.id;
            cart.Quantity = quantity;
            cart.Price = price;
            cart.SpecificallyShoesnName = specificallyShoes.name;
            cart.ShoesImg = specificallyShoes.shoes.image;

            _cartItemRepository.Insert(cart);
        }
    }
}