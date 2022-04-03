using System;

namespace EjerciciosSRP.Ejercicio6
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Email;

        public Persona(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            var _email = new ValidarEmail();
            if (_email.validarMail(email))
                Email = email;
            else
                throw new Exception("Mail inválido");
        }

    }
}