using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cubo
    {
        Cuadrado [] caras { get; set; } = new Cuadrado[6];


        public Cubo(double lado)
        {
            for (int i = 0; i < 6; i++)
            {
                caras[i] = new Cuadrado(lado);
            }
        }

        public double CalcularArea()
        {
            return caras[0].CalcularArea() * caras[1].CalcularArea();
        }

        public double CalcularVolumen()
        {
            double lado = caras[0].Lado;
            return Math.Pow(lado, 3);
        }

        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            string lateralesDescripcion = "";
            for (int n = 0; n < 6; n++)
            {
                lateralesDescripcion += caras[n].Describir() + ", \n";
            }

            string descripcion = $@"{{  
                ""Tipo"": ""Cubo"", 
                 ""Caras"": 
                [
                  {lateralesDescripcion}
                     ],  
                 ""Area"": {CalcularArea().ToString("f2", culture)},
                    ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
                }}";
            return descripcion;
        }
        
    }
}
