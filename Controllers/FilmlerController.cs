using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jsonOrnek.Models;
public class FilmlerController : Controller
{
     public IActionResult Index(){
        return View(Depo.Liste);
    }
    public IActionResult JsonIndex(){
        return View();
    }

    public IActionResult JsonListe(){
        return Json(Depo.Liste);
    }
}