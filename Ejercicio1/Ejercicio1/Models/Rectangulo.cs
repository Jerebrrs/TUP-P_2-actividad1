using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Rectangulo
    {
        public double ancho { get; set;}
        public double largo { get; set;}

       public Rectangulo(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public double CalcularArea()
        {
            return this.ancho * this.largo;

        }

        public string Describir()
        {
            string mensaje = $@"ancho: {ancho} Largo:{largo}";
            return mensaje;
        }
    }
}
