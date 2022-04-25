using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jsonOrnek.Models;
public class FilmlerController : Controller
{
    [HttpGet]
    public IActionResult Ekle(){
        return View();
    }
    [HttpPost]
    public IActionResult Ekle(Film model){
        //depoya film ekle
        if(ModelState.IsValid){
             Depo.Liste.Add(model);
             return RedirectToAction(nameof(JsonIndex));
        } 
        return View(model);

    }
    public IActionResult Index(){
        return View(Depo.Liste);
    }
    public IActionResult JsonIndex(){
        return View();
    }

    public IActionResult JsonListe(){

        return Json(Depo.Liste);
    }
    public IActionResult Sil(string id){ 
    var s=new sonucModel();
    s.mesaj="hata  oluştu x905hatası";
    s.sonuc=false;
    return Json(s);
    }
}