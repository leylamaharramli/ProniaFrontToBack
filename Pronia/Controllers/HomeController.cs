using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Areas.Admin.Controllers;
using Pronia.Context;
using Pronia.ViewModel;
using Pronia.ViewModel.ServiceViewModel;
using Pronia.ViewModel.SliderViewModel;

namespace Pronia.Controllers
{
    public class HomeController(ProniaDbContext context) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var sliders = await context.Sliders.ToListAsync();
            var services = await context.Services.ToListAsync();

            List<SliderGetVM> slidervm = [];
            List<ServiceGetVM> servicevm = [];

            foreach(var item in sliders)
            {
                SliderGetVM slvm = new()
                {
                    Title = item.Title,
                    Description = item.Description,
                    Image = item.Image,
                    Price = item.Price
                };
                slidervm.Add(slvm);
            }

            foreach(var items in services)
            {
                ServiceGetVM sevm = new()
                {
                    Title = items.Title,
                    Description = items.Description,
                    Image = items.Image
                };
                servicevm.Add(sevm);
            }

            HomeVM homeVM = new() { Services = servicevm, Sliders = slidervm };
            return View(homeVM);
        }


        
    }
}
