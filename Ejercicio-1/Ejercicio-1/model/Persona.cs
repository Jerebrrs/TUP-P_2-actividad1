using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    internal class Persona
    {
        public int Dni { get;}
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public string Describir()
        {

            return $@"DNI:{Dni} - nombre: {Nombre}";

        }
    }
}
