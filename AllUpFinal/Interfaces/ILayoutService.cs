using System;
using AllUpFinal.Models;
using AllUpFinal.ViewModels.BasketViewModels;

namespace AllUpFinal.Interfaces
{
	public interface ILayoutService
	{
        Task<IDictionary<string, string> > GetSettings();

        Task<IEnumerable<Category>> GetCategories();

        Task<IEnumerable<BasketVM>> GetBaskets();

    }
}

