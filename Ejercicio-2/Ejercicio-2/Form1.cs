using Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            FigurasVulemetricas[] figuras = new FigurasVulemetricas[6];

            figuras[0] = new Cilindro(3, 3);
            figuras[1] = new Cubo(3);
            figuras[2] = new Ortoedro(7, 7, 21);
            figuras[3] = new Cilindro(9, 13);
            figuras[4] = new Cubo(7);
            figuras[5] = new Cilindro(13, 23);

            tbMostrar.Text += "[ \n";
            foreach (FigurasVulemetricas figura in figuras)
            {
                tbMostrar.Text += figura.Describir() + ",\n";
            }
            tbMostrar.Text += "]";

        }
    }
}
