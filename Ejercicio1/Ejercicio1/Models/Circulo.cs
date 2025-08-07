using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Circulo
    {
        public double radio { get; set; }

        public Circulo(double radio)
        {
           this.radio = radio;
        }

        public double CalcularArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }

        public string Describir()
        {
            return "Soy un rectangulo";
        }

    }
}
