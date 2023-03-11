using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_ShoesStore.Models.Entity
{
	[Table("CartItemDetails")]
	public class CartItemDetails
	{
		

		public CartItemDetails(int id, CartItem cartItem, Shoes shoes, string shoesName, string image, int quantity, decimal price)
		{
			Id = id;
			CartItem = cartItem;
			Shoes = shoes;
			ShoesName = shoesName;
			ShoesImg = image;
			Quantity = quantity;
			Price = price;
		}

        public CartItemDetails()
        {
        }

        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public int cartItemId { get; set; }

		public int shoesId { get; set; }

		[ForeignKey("cartItemId")]
		public CartItem CartItem {get; set; }

		[ForeignKey("shoesId")]
		public Shoes Shoes { get; set; }

		public string ShoesName { get; set; }
		public string ShoesImg { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}
}
