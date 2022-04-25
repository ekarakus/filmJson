using System.ComponentModel.DataAnnotations;

public class Film{
    [Required(ErrorMessage ="Ad boş bırakılamaz")]
    
    public string  Id{get;set;}=Guid.NewGuid().ToString().Substring(0,5);
    public string Ad { get; set; }
    public double Puan { get; set; }
    public string Yonetmen { get; set; }
    public int YapimYili { get; set; }
}
public static class Depo {

    public static  List<Film> Liste= new List<Film>();
    public static List<Film> Doldur(){
        Liste.Add(new Film(){
            Ad="Babam ve Oğlum",
            Yonetmen="Çağan Irmak",
            YapimYili=2005,
            Puan=9
        });
        Liste.Add(new Film(){
            Ad="Hababam Sınıfı",
            Yonetmen="Ertem Eğilmez",
            YapimYili=1975,
            Puan=7
        });
        return Liste;
    }
}