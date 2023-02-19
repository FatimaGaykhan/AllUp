using System;
using AllUpFinal.Models;

namespace AllUpFinal.ViewModels.ProductViewComponentVM
{
	public class PvcVM
	{
		public IEnumerable<Product> BestSellers { get; set; }

		public IEnumerable<Product> NewArrivals { get; set; }

		public IEnumerable<Product> Features { get; set; }
    }
}

