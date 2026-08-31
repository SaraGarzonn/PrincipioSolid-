using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Dependencias
{
    public class PagoConPayPal : IMetodoPago
    {
        public void Procesar(decimal monto)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("PAGO CON PAYPAL");
            Console.WriteLine($"Monto cobrado: ${monto:N0}");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
