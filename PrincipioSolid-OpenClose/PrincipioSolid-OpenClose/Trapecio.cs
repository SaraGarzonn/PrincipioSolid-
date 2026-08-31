using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid_OpenClose
{
    public class Trapecio : Shape
    {
        public double Basemenor { get; set; }
        public double Basemayor { get; set; }
        public double Altura { get; set; }

        public override double Area() => ((this.Basemayor + this.Basemenor) * this.Altura) / 2;
    }
}
