using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Mail;

/// <summary>
/// Descripción breve de SendMail
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SendMail : System.Web.Services.WebService
{

    public SendMail()
    {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string SendMailTo(int _id,string _pass, string _email)
    {
        try
        {
            MailMessage _message = new MailMessage();
            _message.From = new MailAddress("mi.carcochita@live.com.pe");
            _message.To.Add(new MailAddress(_email));
            _message.Subject = "Bienvenido a Mi Carcochita";
            string _body = "Mi carcochita te da la bienvenida a nuestro sistema web.\r\n Tu cuenta ha sido activada. \r\n Tu usuario es " + _id.ToString() + "\r\n Tu clave es " + _pass.ToString();
            _message.Body = _body;
            _message.IsBodyHtml = false;
            SmtpClient _smtp = new SmtpClient();
            _smtp.EnableSsl = true;
            _smtp.Send(_message);
            return "Su cuenta ha sido activda. Por favor revise su correo";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

}

