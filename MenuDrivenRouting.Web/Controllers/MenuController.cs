using Microsoft.AspNetCore.Mvc;

namespace MenuDrivenRouting.Web.Controllers;
public class MenuController : Controller
{
    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Customers()
    {
        return View();
    }

    public IActionResult Products()
    {
        return View();
    }

    public IActionResult Orders()
    {
        return View();
    }
}
