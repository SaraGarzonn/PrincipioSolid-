using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID_Interface
{
    public class LibroFisico:ILeible
    {
        public string Titulo {  get; set; }

        public void Leer(int pagina) => Console.WriteLine($"Leyendo el libro {Titulo} en la pagina numero: {pagina}");

    }
}
