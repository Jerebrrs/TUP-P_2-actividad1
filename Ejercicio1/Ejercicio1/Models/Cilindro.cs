using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cilindro
    {
        Circulo[] tapas = new Circulo[2];
        RectanguloDesarrollado lado;
        

        public Cilindro(double radio, double altura)
        {
            tapas[0] = new Circulo(radio);
            tapas[1]= new Circulo(radio);

            lado = new RectanguloDesarrollado(radio,altura);
        }

        public double CaclularArea()
        {
            return tapas[0].CalcularArea() * lado.CalcularArea() *2;
        }

        public double CalcularVolumen()
        {
            return tapas[0].CalcularArea() * lado.Largo;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"{{
            ""Tipo"" : ""Cilindro"",
            ""Tapas"" : [
             {tapas[0].Describir()},
             {tapas[1].Describir()}
             ],
             ""Lado"" : {lado.Describir()},
             ""Area"" : {CaclularArea().ToString("f2",culture)},
             ""Volumen"" : {CalcularVolumen().ToString("f2",culture)}
            }}";
        }


    }
}
