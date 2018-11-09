using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    [Serializable]
    public class Correo
    {
        private readonly String servCorreo = "avot.agencia@gmail.com";
        private readonly String passwd = "Avot.2018";
        public bool EnvioDeCorreos(String emailUsuario, String nombreUsuario)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(emailUsuario));
            email.From = new MailAddress(servCorreo);
            email.Subject = "Actualización de contraseña Agencias de viaje On Tour";
            email.Body = nombreUsuario + ": Este es un correo de con un enlace para reiniciar la contraseña de tu usuario de AVOT. aprete el siguiente link para registrar una nueva contraseña <a href = \"http://localhost:56702/ActualizarContraseña.aspx/?" + "us=" + nombreUsuario+"\">confirmacion</a>";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.High;

            SmtpClient stmp = new SmtpClient("smtp.gmail.com")
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential(servCorreo, passwd)
            };
            try
            {
                stmp.Send(email);
                email.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
