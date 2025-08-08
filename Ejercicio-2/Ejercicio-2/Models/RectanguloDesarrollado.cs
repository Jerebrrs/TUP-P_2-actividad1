using System;
using System.Globalization;

namespace Ejercicio_2.Models
{
    internal class RectanguloDesarrollado : Rectangulo
    {
        /*Se usa la palabra BASE para llamar el constructor de la clase padre
         No Hace falta inicializar las variable largo y ancho porq las Hereda de rectangulo*/
        public RectanguloDesarrollado(double altura, double radio) : base (2*Math.PI*radio,altura)
        {
        }
        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"{{
            ""Tipo"" : ""Rectangulo Desarrollado"",
            ""Largo"" : {Largo.ToString("f2", culture)},
            ""Ancho"" : {Ancho.ToString("f2", culture)},
            ""Area"" : {CalcularArea().ToString("f2", culture)}
            }}";
        }
    }
}