using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2.Models
{
    internal class Circulo : FiguraPlana
    {
        public double Radio {  get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            return area;
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"{{
                ""Tipo"" : ""Circulo""
                ""Radio"" : {Radio.ToString("f2", culture)},
                ""Area"" : {CalcularArea().ToString("f2", culture)}
             }}";
        }
    }
}
