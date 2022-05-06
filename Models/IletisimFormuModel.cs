using System.ComponentModel.DataAnnotations;

public class IletisimFormuModel{

    [Required(ErrorMessage ="Ad Soyad giriniz")]
    [Display(Name ="Ad Soyad")]
    public string AdSoyad{get;set;}

    [Required(ErrorMessage ="Mesaj giriniz")]
    public string Mesaj { get; set; }

    [EmailAddress(ErrorMessage ="Geçerli bir email adresi giriniz")]
    [Required(ErrorMessage ="Email giriniz")]
    public string Email { get; set; }

}