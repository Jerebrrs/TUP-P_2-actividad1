using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RectanguloDesarrollado
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public RectanguloDesarrollado(double altura , double radio) {
            Ancho = radio * Math.PI *2;
            Largo = altura;
        }

        public double CalcularArea() {
            return Largo * Ancho;
        }

        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"{{
            ""Tipo"" : ""Rectangulo Desarrollado"",
            ""Largo"" : {Largo.ToString("f2",culture)},
            ""Ancho"" : {Ancho.ToString("f2",culture)}
            ""Area"" : {CalcularArea().ToString("f2",culture)}
            }}";
        }
    }
}
