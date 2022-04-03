using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio4
{
    public class Imprimir
    {
        private string Titulo;
        private string Contenido;
        public void ImprimirLibro()
        {
            Console.WriteLine(Titulo);
            Console.WriteLine(Contenido);
        }
    }
}
