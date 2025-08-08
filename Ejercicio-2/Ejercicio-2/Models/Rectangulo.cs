using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    internal class Rectangulo : FiguraPlana
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho) {
            Largo=largo;
            Ancho=ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;


            return $@"{{
            ""Tipo"": ""Rectangulo"",
            ""Ancho"": {Ancho.ToString("f2", culture)},
            ""Largo"":{Largo.ToString("f2", culture)},
            ""Area"" : {CalcularArea().ToString("f2", culture)}
            }}";
        }
    }
}
