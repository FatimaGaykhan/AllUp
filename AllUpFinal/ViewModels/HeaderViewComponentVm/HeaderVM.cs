using System;
using AllUpFinal.Models;
using AllUpFinal.ViewModels.BasketViewModels;

namespace AllUpFinal.ViewModels.HeaderViewComponentVM
{
	public class HeaderVM
	{
		public IDictionary<string,string> Settings { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public IEnumerable<BasketVM> BasketVMs { get; set; }
	}
}

