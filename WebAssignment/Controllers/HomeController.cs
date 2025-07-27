using Microsoft.AspNetCore.Mvc;

namespace WebAssignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Demo1(String name, int age)
    {
        ViewBag.Name = name;
        ViewBag.Age = age;
        return View();
    }

}
