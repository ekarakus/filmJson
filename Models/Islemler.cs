using System.Net.Mail;

public static class Islemler
{
    public static void MailGonder(string baslik, string icerik, string alici)
    {
        MailMessage ePosta = new MailMessage();
        ePosta.From = new MailAddress("Uğur Bilişim <ugurholdingdeneme@gmail.com> ");
        ePosta.Subject = baslik;
        ePosta.Body = icerik;
        ePosta.IsBodyHtml = true;
        ePosta.To.Add(alici);

        SmtpClient smtp = new SmtpClient();
        //
        smtp.Credentials = new System.Net.NetworkCredential("ugurholdingdeneme@gmail.com", "deneme1234+-*");
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        smtp.Send(ePosta);
    }
}