using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID_Interface
{
    public interface IEscuchable
    {
        void Escuchar(int minuto);
        void CambiarVelocidad(double velocidad);
    }
}

