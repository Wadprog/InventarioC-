using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class PrimeNumbers : Form
    {
        public PrimeNumbers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;

            try
            {
                n = Convert.ToInt16(textBox1.Text.Trim());
            }
            catch (Exception)
            {

                return;
            }

            if (Utilidades.Utilidad.Primo(n))
            {
                MessageBox.Show("Es primo");

            }
            else {
                MessageBox.Show("No es primo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            

            int cp = 0, n = 0;
            while (cp<100) {
                n++;
                if (Utilidades.Utilidad.Primo(n))
                {
                    cp++;
                    richTextBox1.Text += n.ToString()+",";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
