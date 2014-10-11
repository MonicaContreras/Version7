using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersona
{
    class Persona
    {
        string nombre;
        int edad;

        public Persona()
        {
 
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set 
            {
                edad = value;
            }
        }
    }
}
