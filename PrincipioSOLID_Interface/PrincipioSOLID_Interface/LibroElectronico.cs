using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID_Interface
{
    public class LibroElectronico:IEscuchable, ILeible
    {
        public string Titulo {  get; set; }

        public void Leer(int pagina) => Console.WriteLine($"Leyendo el libro {Titulo} en la pagina numero: {pagina}");
        public void Escuchar(int minuto) => Console.WriteLine($"Escuchando el audio Libro {Titulo}, Minuto de reproduccion {minuto}");
        public void CambiarVelocidad(double velocidad) => Console.WriteLine($"Velocidad de Reproduccion: {velocidad}X");


    }
}
