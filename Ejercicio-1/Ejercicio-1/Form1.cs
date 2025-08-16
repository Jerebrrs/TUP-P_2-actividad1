using Ejercicio_1.model;
using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVer.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            lbMostrar.SelectedIndexChanged += lbMostrar_SelectedIndexChanged;
        }
        Servicio service = new Servicio();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPersona vtnPersonas = new DatosPersona();

            if (vtnPersonas.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(vtnPersonas.textBox1.Text);
                string nombre = vtnPersonas.textBox2.Text;
                Persona persona = new Persona(dni, nombre);
                
               bool creapersona = service.AgregarPersona(persona);
                if (creapersona != false)
                {
                    MessageBox.Show("Se creo la persona");

                } else
                {
                    MessageBox.Show("No se creo la persona");
                }
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbMostrar.Items.Clear();
            for (int i = 0; i < service.VerCantidadDePersonas(); i++)
            {
                lbMostrar.Items.Add(service.VerPersona(i).Describir().ToString());
                
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idx = lbMostrar.SelectedIndex;

            if(idx != -1)
            {
                Persona persona = service.VerPersona(idx);
                MessageBox.Show($"DNI: {persona.Dni} - Nombre: {persona.Nombre}");
            }
           
          
        }

        private void lbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVer.Enabled = lbMostrar.SelectedIndex != -1;
            btnModificar.Enabled = lbMostrar.SelectedIndex != -1;
            btnEliminar.Enabled = lbMostrar.SelectedIndex != -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosPersona vtnper = new DatosPersona();

            int idx = lbMostrar.SelectedIndex;
            if (idx != -1)
            {
                Persona persActual = service.VerPersona(idx);
                vtnper.textBox1.Text = persActual.Dni.ToString();
                vtnper.textBox2.Text = persActual.Nombre;
                if(vtnper.ShowDialog()== DialogResult.OK)
                {
                    string nvNombre = vtnper.textBox2.Text;
                    persActual.Nombre = nvNombre;
                }
                btnListar_Click(null, null);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            int idx = lbMostrar.SelectedIndex;

            service.EliminarPersona(service.VerPersona(idx));
            btnListar_Click(null, null);
        }
    }
}
