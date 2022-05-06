using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jsonOrnek.Models;
using System.Net.Mail;

namespace jsonOrnek.Controllers;

public class HomeController : Controller

{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
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
    public IActionResult Iletisim()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Iletisim(IletisimFormuModel m)
    {
        sonucModel cevap = new sonucModel();
        string baslik = "Yeni mesaj";
        string icerik = $" Mesaj Gönderen : {m.AdSoyad} <br> Email : {m.Email} <br> Mesaj:{m.Mesaj}";
        string alici = "ekarakus@btofis.com";
        try
        {
            Islemler.MailGonder(baslik, icerik, alici);
            cevap.sonuc = true;
            cevap.mesaj = "Email Gönderildi";
        }
        catch (System.Exception e)
        {
            cevap.sonuc = false;
            cevap.mesaj = e.Message;
        }
ViewBag.Sonuc=cevap;
        return View();
    }
}
