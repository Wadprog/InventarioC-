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
    public partial class EjpValidacion : Form
    {
        public EjpValidacion()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but_validar_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is Utilidades.textbox)
                {
                    Utilidades.textbox obj = (Utilidades.textbox) item;
                    if (obj.Validar)
                    {
                        errorProvider1.SetError(obj, String.IsNullOrEmpty(obj.Text.Trim()) ? "Required Field" : "");
                    }
                }
            }

            
        }

        private void but_validar2_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidad.ValidaForm.ValiForm(this, errorProvider1);
        }

        private void EjpValidacion_Load(object sender, EventArgs e)
        {

        }
    }
}
