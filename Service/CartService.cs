
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
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
		// CartItem == doi giay
		//Get list of CartItem
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

		//Get CartItem by id
		public CartItem GetCartItemById(int CartItemId)
		{
			return _cartItemRepository.GetById(CartItemId);
		}

		//Get CartItem by name
		public IEnumerable<CartItem> GetCartItemByName(string CartItemname)
		{
			// Build an expression that filters the data based on the name
			return _cartItemRepository.GetData(s => s.SpecificallyShoesnName == CartItemname);
		}

		//Update [NumberInStock] when buying [quantity] CartItem (MinusNumberInStockWithQuantity)
		// Ex: stock: 100                         quantity:2  --> stock: 88
		public bool UpdateCartItem(CartItem CartItem)
		{
			//ham nay chua code
			return false;
		}
	}
}
