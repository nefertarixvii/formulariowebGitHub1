using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formularioGitHub.Models;

namespace formularioGitHub.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Muestra el formulario
    public IActionResult Index()
    {
        return View();
    }

    // Procesa el formulario
    [HttpPost]
    public IActionResult Index(string nombre, DateTime fecha, string hobbies, string pago)
    {
        if (pago == "no")
        {
            ViewBag.Mensaje = "Usted aún no ha completado su pago.";
        }
        else
        {
            ViewBag.Mensaje = "Registro completado correctamente.";
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}