using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.model
{
    internal class Servicio
    {
        private List<Persona> personas = new List<Persona>();
     
        public bool AgregarPersona(Persona persona) {

            Persona p = VerPersonaPorDni(persona.Dni);

            if (p == null)
            {
                personas.Add(persona);
                return true;
            }
            return false;


        }

        public int VerCantidadDePersonas()
        {

            return personas.Count();
        }

        public Persona VerPersona(int n)
        {
            if(n>=0 && n<personas.Count)
                return personas[n] ;
            return null;
        }

        public Persona VerPersonaPorDni(int dni)
        {
            int idx = -1;
            int n = 0;
            while(idx==-1 && n<personas.Count)
            {
                if (dni == personas[n].Dni)
                {
                    idx = n;
                }
                n++;
            }
            if (idx > -1)
            {
                return personas[idx];
            }
            return null;
        }

        public void EliminarPersona(Persona persona)
        {
            personas.Remove(persona);
        }
    }
}
