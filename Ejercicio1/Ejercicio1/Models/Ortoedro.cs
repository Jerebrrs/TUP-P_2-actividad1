using System;
using System.Collections.Generic;
using System.Drawing.Text;
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
            string mensaje = $@"soy un ortoegro {bases[0].Describir()}";
            return mensaje;
        }

    }
}
