using System;
using System.Collections.Generic;
using System.Globalization;
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
            var culture = CultureInfo.InvariantCulture;


            return $@"{{
            ""Tipo"": ""Rectangulo"",
            ""Ancho"": {ancho.ToString("f2",culture)},
            ""Largo"":{largo.ToString("f2",culture)},
            ""Area"" : {CalcularArea().ToString("f2",culture)}
            }}";
        }
    }
}
