using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Dependencias
{
        public class ProcesadorCompra
        {
           
            private readonly IMetodoPago metodoPagoElegido;

          
            public ProcesadorCompra(IMetodoPago metodoPago)
            {
               
                metodoPagoElegido = metodoPago;
            }

           
            public void Pagar(decimal monto)
            {
                metodoPagoElegido.Procesar(monto);
            }
        }
    
}
