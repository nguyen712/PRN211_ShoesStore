using PRN211_ShoesStore.Models.Entity;
using System.Collections.Generic;

namespace PRN211_ShoesStore.Service
{
    public interface ICartService
    {
        IEnumerable<CartItem> GetCartItem();

        //Get CartItem by id
        CartItem GetCartItemById(int CartItemId);
        //Get CartItem by name
        IEnumerable<CartItem> GetCartItemByName(string CartItemname);

        //Update [NumberInStock] when buying [quantity] CartItem (MinusNumberInStockWithQuantity)
        // Ex: stock: 100                         quantity:2  --> stock: 88
        bool UpdateCartItem(CartItem CartItem);

        public IEnumerable<CartItem> GetCartItemDetails();
    }
}
