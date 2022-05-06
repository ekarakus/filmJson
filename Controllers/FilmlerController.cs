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
    var aranan=Depo.Liste.Where(x=>x.Id==id)
    .FirstOrDefault();
    //aranana kayıt var ise
    if(aranan!=null){
        Depo.Liste.Remove(aranan);
        s.mesaj="kayıt silindi";
        s.sonuc=true;
    }else{
        s.sonuc=false;
        s.mesaj="aranan kayıt bulunamadı";
    }
    return Json(s);
    }
}