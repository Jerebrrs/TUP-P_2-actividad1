using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cuadrado
    {
        public double Lado { get; set; }
        
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public double CalcularArea()
        {
            return Lado * Lado;
        }
        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;
            return $@"{{
            ""Tipo"": ""Cuadrado"",
            ""Lado"": {Lado.ToString("f2",culture)},
            ""Area"": {CalcularArea().ToString("f2",culture)}
            }}";
        }
    }
}
