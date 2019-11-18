using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Inventario
{
    public partial class Traductor : Form
    {
        public Traductor()
        {
            InitializeComponent();
            but_esc.Enabled = false;
            
        }

        Utilidades.Numeros nm = new Utilidades.Numeros();
        

        private void Traductor_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("DEBE LLENAR EL CAMPO CON POR LO MENOS UN NUMERO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                but_esc.Enabled = true;
            }

            trad_txt.Text = nm.enletras(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("DEBE LLENAR EL CAMPO CON POR LO MENOS UN NUMERO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            String letras = "";
            String[] split = trad_txt.Text.Split(' ');
            
            
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            
            
            
            for (int i = 0; i < split.Length; i++)
            {
                letras= @"C:\Users\lenovo\Documents\Sound recordings\Numeros\" + split[i] + ".wav";
                
                
                sound.SoundLocation = letras;

                sound.PlaySync();
            }
           
           


        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void trad_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
