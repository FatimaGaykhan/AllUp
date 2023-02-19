using System;
using AllUpFinal.Models;

namespace AllUpFinal.ViewModels.HomeViewModels
{
	public class HomeVM
	{
		public IEnumerable <Slider> Sliders{ get; set; }
		public IEnumerable <Category> Categories { get; set; }
		public IEnumerable<Product> Features { get; set; }
		public IEnumerable<Product> NewArrival{ get; set; }
		public IEnumerable<Product> BestSeller{ get; set; }

	}
}

