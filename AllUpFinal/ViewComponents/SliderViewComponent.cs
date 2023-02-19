using System;
using AllUpFinal.DataAccessLayer;
using AllUpFinal.Models;
using AllUpFinal.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpFinal.ViewComponents
{
	public class SliderViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;

		public SliderViewComponent(AppDbContext context)
		{
			_context = context;
		}
		
		public async Task<IViewComponentResult> InvokeAsync()
		{
			List<Slider> sliders = await _context.Sliders.ToListAsync();
			return View(await Task.FromResult(sliders));
		}
		
	}
}

