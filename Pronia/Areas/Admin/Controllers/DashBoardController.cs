using Microsoft.AspNetCore.Mvc;
using Pronia.Repositories.Implementations;
using System.Runtime.InteropServices;

namespace Pronia.Areas.Admin.Controllers;

[Area("Admin")]
public class DashBoardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Create()
    {
        SliderRepository repository = new();
        await repository.AddAsync(new() { Title = "Emiliya", Description = "BlaBla", Price = 10, ImagePath = "1-1-120x120.webp" });
        return Ok("done");
    }
}
