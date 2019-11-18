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
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }
        Utilidades.Numeros nm = new Utilidades.Numeros();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matriz_1_Click(object sender, EventArgs e)
        {
            int[,] z = new int[5, 5];
            //Llenar matriz

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f == c) z[f, c] = 1;
                    else if(f + c == 4)
                    {
                         z[f, c] = 2;
                    }else if (f < c)
                    {
                        if (f + c < 5) z[f, c] = 3;
                        else
                        {
                            z[f, c] = 4;
                        }
                    }else if (f > c)
                    {
                        if (f + c >= 5) z[f, c] = 5;
                        else
                        {
                            z[f, c] = 6;
                        }
                    }
                    
                }
            }
            String matriz = "";


            //Imprimir
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    matriz += z[i, j].ToString()+"\t";
                }
                matriz += "\n";
            }

            richTextBox1.Text = matriz;
        }







        private void but_limp_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void matriz_2_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            int z = 1, a=6;

            for(int f = 0; f < 5; f++)
            {
                for(int c = 0; c < 5; c++)
                {
                    if (f == c)
                    {
                        m[f, c] = z++;
                    }
                    else if (f + c == 4)
                    {
                        m[f, c] = a++;
                    }else if (c-f ==c)
                    {
                        m[f, c] = c;
                    }else if (c - f == -f)
                    {
                        m[f, c] = c - f;
                    }else if (c==4)
                    {
                        m[f, c] = c - f;
                    }else if (f + c == 7)
                    {
                        m[f, c] =7;
                    }else if (f + c == 5)
                    {
                        m[f, c] = 5;
                    }else if (c - f < 0)
                    {
                        m[f, c] = c - f;
                    }
                    else
                    {
                        m[f, c] = 1;
                    }
                    

                }
            }
            String matriz = "";

            int sum = 0;
            //Imprimir
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz += m[i, j].ToString() + "\t";
                    if (Utilidades.Utilidad.Primo(m[i, j]))
                    {
                        sum++;
                    }
                }
                matriz += "\n";
            }

            richTextBox1.Text = matriz;
            //Primo
            

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if( Utilidades.Utilidad.Primo(m[i, j])){
                        sum++;
                    }
                }
            }

            cantp_txt.Text = sum.ToString();//CANTIDAD DE PRIMOS

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 3)
                    {
                        double x = Math.Pow(sum,m[i, j]);
                        double h = Math.Round(x);
                        rsult_txt.Text = h.ToString();//RESULTADO

                        reslet_txt.Text = nm.enletras(rsult_txt.Text);//RESULTADO EN LETRAS 
                                            
                    }
                }
            }

             




        }

        private void button1_Click(object sender, EventArgs e)
        {
            String letras = "";
            String[] split = reslet_txt.Text.Split(' ');


            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();



            for (int i = 0; i < split.Length; i++)
            {
                letras = @"C:\Users\lenovo\Documents\Sound recordings\Numeros\" + split[i] + ".wav";


                sound.SoundLocation = letras;

                sound.PlaySync();
            }

        }
     
    }
}
