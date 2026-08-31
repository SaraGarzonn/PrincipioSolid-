using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Dependencias
{
    public interface IMetodoPago
    {
       void Procesar(decimal monto);
    }
}
