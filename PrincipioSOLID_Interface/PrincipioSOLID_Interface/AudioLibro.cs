using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID_Interface
{
    internal class AudioLibro:IEscuchable
    {
        public string Titulo {  get; set; }

        public void Escuchar(int minuto) => Console.WriteLine($"Escuchando el audio Libro {Titulo}, Minuto de reproduccion {minuto}");
        public void CambiarVelocidad(double velocidad) => Console.WriteLine($"Velocidad de Reproduccion: {velocidad}X");

      
    }
}
