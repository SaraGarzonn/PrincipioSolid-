using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_OpenClose
{
    public class Hexagono : Shape
    {
        public double Perimetro { get; set; }
        public double Apotema { get; set; }

        public override double Area() => (this.Perimetro * this.Apotema) / 2;
    }
}
