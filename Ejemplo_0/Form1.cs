using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Mensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primer mensaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacion();

        }

        private void validacion()
        {
            if (textBox1.Text=="")
            {

            }
        }
    }
}
