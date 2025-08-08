using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    internal class Cilindro : FigurasVulemetricas
    {
        Circulo[] tapas = new Circulo[2];
        RectanguloDesarrollado lado;


        public Cilindro(double radio, double altura)
        {
            tapas[0] = new Circulo(radio);
            tapas[1] = new Circulo(radio);

            lado = new RectanguloDesarrollado(radio, altura);
        }

        public override double CalcularArea()
        {
            return tapas[0].CalcularArea() * lado.CalcularArea() * 2;
        }

        public override double CalcularVolumen()
        {
            return tapas[0].CalcularArea() * lado.Largo;
        }

        public override string Describir()
        {
           var culture = CultureInfo.InvariantCulture;

            return $@"{{
            ""Tipo"" : ""Cilindro"",
            ""Tapas"" : [
             {tapas[0].Describir()},
             {tapas[1].Describir()}
             ],
             ""Lado"" : {lado.Describir()},
             ""Area"" : {CalcularArea().ToString("f2", culture)},
             ""Volumen"" : {CalcularVolumen().ToString("f2", culture)}
            }}";
        }
    }
}
