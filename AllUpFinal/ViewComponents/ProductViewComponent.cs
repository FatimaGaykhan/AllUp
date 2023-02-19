using System;
using AllUpFinal.DataAccessLayer;
using AllUpFinal.Models;
using AllUpFinal.ViewModels.ProductViewComponentVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpFinal.ViewComponents
{
	public class ProductViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;


		public ProductViewComponent(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			PvcVM products = new PvcVM
			{
				BestSellers = await _context.Products.Where(p=>!p.IsDeleted && p.IsBestSeller).ToListAsync(),
				Features = await _context.Products.Where(p=>!p.IsDeleted && p.IsFeatured).ToListAsync(),
				NewArrivals = await _context.Products.Where(p=>!p.IsDeleted && p.IsNewArrival).ToListAsync()
            };
			
			//List<Product> products = await _context.Products.ToListAsync();
			return View( await Task.FromResult(products));
		}
	}
}

