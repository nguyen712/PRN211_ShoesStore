using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN211_ShoesStore.Models.Entity
{
	public class CartItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("userId")]
		public int UserId { get; set; }

		[ForeignKey("specificallyShoesId")]
		public int SpecificallyShoesId { get; set; }
		public string SpecificallyShoesnName { get; set; }
		public string ShoesImg { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public CartItem(int id, int userId, int specificallyShoesId, string specificallyShoesnName, string shoesImg, int quantity, decimal price)
		{
			Id = id;
			UserId = userId;
			SpecificallyShoesId = specificallyShoesId;
			SpecificallyShoesnName = specificallyShoesnName;
			ShoesImg = shoesImg;
			Quantity = quantity;
			Price = price;
		}
	}
}
