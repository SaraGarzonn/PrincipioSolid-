using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Liskovs
{
    public class TrabajadorComision:Empleado
    {
        public decimal NumeroVentas {  get; set; }
        public decimal ComisionVenta { get; set; } = 30000;

        public override decimal CalcularPago() => (SalarioBase + (NumeroVentas * ComisionVenta));

    }
}
