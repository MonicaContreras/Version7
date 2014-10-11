using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //crear los objetos personas
            Persona persona1 = new Persona(txtnombre.Text, int.Parse(txtedad.Text));
            if (persona1.Edad >= 18)
            {
                MessageBox.Show("La edad de "+persona1.Nombre+" es de "+persona1.Edad+" es mayor de edad");

            }
            else
                MessageBox.Show("La edad de " + persona1.Nombre + " es de " + persona1.Edad + " es menor de 18 ");

        }
    }
}
