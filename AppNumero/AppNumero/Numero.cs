using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Numero
    {
        int numeromayor;
        int numeromenor;

        public Numero(int numeromenor, int numeromayor)
        {
            this.numeromayor = numeromayor;
            this.numeromenor = numeromenor;

        }

        public int Numeromayor
        {
            get
            {
                return numeromayor;
            }
            set
            {
                numeromayor = value;
            }
        }

        public int Numeromenor
        {
            get
            {
                return numeromenor;
            }
            set
            {
                numeromenor = value;

            }
        }

            public List<int> Mostrar()
            {   
             List<int> rango=new List<int>();
                for(int contador=numeromenor; contador<= Numeromayor; contador++)
                {
                    rango.Add(contador);
                }
            
        return rango;
            }
        }
    }




