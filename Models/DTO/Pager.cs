using System;

namespace PRN211_ShoesStore.Models.DTO
{
	public class Pager
	{
		public int TotalItems { get; set; }
		public int CurrentPage { get; set; }
		public int PageSize { get; set; }
		public int TotalPages { get; set; }
		public int StartPage { get; set; }
		public int EndPage { get; set; }

		public Pager() { }
		public Pager(int totalItems, int page, int pageSize) {
		
			int totalPages = (int)Math.Ceiling((decimal) totalItems / (decimal) pageSize);
			

		}


	}
}
