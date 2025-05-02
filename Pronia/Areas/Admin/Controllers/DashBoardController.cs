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

    
}
