using System.Net.Mail;


namespace EjerciciosSRP.Ejercicio5
{
    public class FacturaRepositorio
    {
        public void GuardarFactura(Factura factura)
        {
            //Código para guardar factura
            var _email = new NotificarViaEmail();
            _email.EnviarFacturaAlEmail(new MailMessage());
        }
        
        public void EliminarFactura(string numeroFactura)
        {
            //Código para eliminar factura
        }
       
    }
}