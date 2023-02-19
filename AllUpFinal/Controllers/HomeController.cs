using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpFinal.DataAccessLayer;
using AllUpFinal.Servicess;
using AllUpFinal.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AllUpFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;



        public HomeController(AppDbContext context)
        {
            _context = context;
           
        }

        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s=>s.IsDeleted==false).ToListAsync(),
                Categories=await _context.Categories.Where(c=>c.IsDeleted==false && c.IsMain).ToListAsync(),
                Features =await _context.Products.Where(p=>p.IsDeleted==false&&p.IsFeatured).ToListAsync(),
                BestSeller=await _context.Products.Where(p=>p.IsDeleted==false&&p.IsBestSeller).ToListAsync(),
                NewArrival=await _context.Products.Where(p=>p.IsDeleted==false&&p.IsNewArrival).ToListAsync()
                
            };

            return View(vm);
        }



        //public async Task<IActionResult> SetSession()
        //{
        //    HttpContext.Session.SetString("P133", "First Session Data");
        //    return Content("Session Elave olundu");
        //}

        //public async Task<IActionResult> GetSession()
        //{
        //    var ses = HttpContext.Session.GetString("P133");
        //    return Content(ses);
        //}

        //public async Task<IActionResult> SetCookie()
        //{
        //    HttpContext.Response.Cookies.Append("P133", "First Cookie data");

        //    return Content("Cookie elave olundu");
        //}
        //public async Task<IActionResult> GetCookie()
        //{
        //    string a = HttpContext.Request.Cookies["P133"];
        //    return Content(a);
        //}


    }

}

