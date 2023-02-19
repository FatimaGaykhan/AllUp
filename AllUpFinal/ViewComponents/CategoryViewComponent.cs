using System;
using AllUpFinal.DataAccessLayer;
using AllUpFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpFinal.ViewComponents
{
	public class CategoryViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;

		public CategoryViewComponent(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Category> categories = await _context.Categories.ToListAsync();
            return View(await Task.FromResult(categories));
		}
	}
}

