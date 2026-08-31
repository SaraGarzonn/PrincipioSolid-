using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_Liskovs
{
    public abstract class Empleado
    {
        public string Nombre {  get; set; }
        public decimal SalarioBase { get; set;}

        public abstract decimal CalcularPago();

        public void MostrarRecibo()
        {
            int ancho = 40;

            Console.WriteLine(new string('=', ancho));
            Console.WriteLine("RECIBO DE PAGO");
            Console.WriteLine(new string('-', ancho));
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Tipo: {GetType().Name}");
            Console.WriteLine($"Total Sueldo: $ {CalcularPago():N0}");
            Console.WriteLine(new string('=', ancho));
            Console.WriteLine();
        }
    }
}

