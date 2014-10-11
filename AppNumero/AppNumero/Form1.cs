using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(int.Parse(txtnumeromenor.Text), int.Parse(txtnumeromayor.Text));
            List<int> rangonumero = new List<int>();
            rangonumero = numero1.Mostrar();

            foreach (int contador2 in rangonumero)
            {
                rtbmostrar.Text = rtbmostrar.Text + " " + contador2.ToString();
            }

        }
    }
}
