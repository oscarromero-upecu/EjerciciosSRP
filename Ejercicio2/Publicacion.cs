using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio2
{
    class Publicacion
    {
        public void CrearPublicacion(DbContext contextoDB, string mensajeAPublicar)
        {
            try
            {
                contextoDB.Add(mensajeAPublicar);
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
