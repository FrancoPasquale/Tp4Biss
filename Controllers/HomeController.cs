using Microsoft.AspNetCore.Mvc;

namespace TP4bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = info.ListarPaises();
        return View("index");
    }
   public IActionResult DetallePais(string Pais)
    {
        ViewBag.PaisBuscado = info.DetallePais(Pais);



        return View("detallePais");
    }
}
