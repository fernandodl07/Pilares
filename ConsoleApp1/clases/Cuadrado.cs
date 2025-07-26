using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.clases
{
    public class Cuadrado: Figura
    {
        public double lado;

        public Cuadrado(string color, double lado) : base(color)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return this.lado * this.lado;
        }

        public string MostrarFigura()
        {
            return "";
        }

    }
}
