using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Ortoedro
    {
        public Rectangulo[] laterales = new Rectangulo[4];
        public Rectangulo[] bases = new Rectangulo[2];

        public Ortoedro(double anchoBase, double ladoComun, double largoLateral) {
            bases[0] = new Rectangulo(anchoBase, ladoComun);
            bases[1] = new Rectangulo(anchoBase, ladoComun);
            laterales[0] = new Rectangulo(ladoComun, largoLateral);
            laterales[1] = new Rectangulo(ladoComun, largoLateral);
            laterales[2] = new Rectangulo(ladoComun, largoLateral);
            laterales[3] = new Rectangulo(ladoComun, largoLateral);
        }

        public double CalcularArea()
        {
            double areaBase = bases[0].CalcularArea();
            double arealateral = laterales[0].CalcularArea();

            return areaBase * 2 + arealateral * 4;
        }


        public double CalcularVolumen()
        {
            double volumen = 0;

            double anchoBase = bases[0].CalcularArea();
            double largolateral = laterales[0].largo;

            return volumen = (double) anchoBase * largolateral;
        }

        public string Desribir()
        {
            var culture = CultureInfo.InvariantCulture;

            string lateralesDesc = "";
            for (int i = 0; i < 3; i++)
            {
                lateralesDesc += laterales[i].Describir() + " \n";
            }
            lateralesDesc += laterales[3].Describir();
            return $@"{{
            ""Tipo"" : ""Ortoedro"",
                ""Tapas"" :
                [
                 {bases[0].Describir()}
                 {bases[1].Describir()}
                ],
                ""Laterales"": [
                {lateralesDesc}
                ],
                ""Area"": {CalcularArea().ToString("f2",culture)},
                ""Volumen"": {CalcularVolumen().ToString("f2",culture)}
            }}";
        }

    }
}
