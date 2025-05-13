﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Context;
using Pronia.Models;

namespace Pronia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(ProniaDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            var sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            
            if (!ModelState.IsValid)
                return View(slider);

            await context.Sliders.AddAsync(slider);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete (int? id)
        {
            
            if (id is null || id < 1)
                return BadRequest();

            var slider = await context.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (slider is null)
                return NotFound();

            context.Sliders.Remove(slider);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
