using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio6
{
    public class ValidarEmail
    {
        public bool validarMail(string email)
        {
            try
            {
                var direccionCorreo = new System.Net.Mail.MailAddress(email);
                return direccionCorreo.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
