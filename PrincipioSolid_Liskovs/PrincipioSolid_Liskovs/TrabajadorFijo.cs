using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Liskovs
{
    public class TrabajadorFijo:Empleado

    {
        public override decimal CalcularPago()
        {
            return SalarioBase;
        }
    }
}
