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
    public partial class FormBase : Form
    {
        public virtual void Salvar() { }

        public virtual void Eliminar() { }

        public virtual void Consultar() { }

        public virtual void Imprimir() { }

        public virtual void Limpiar() { }


        public bool PuedeSalvar {
            get;
            set;
        }

        public bool PuedeEliminar
        {
            get;
            set;
        }

        public bool PuedeConsultar
        {
            get;
            set;
        }

        public bool PuedeImprimir
        {
            get;
            set;
        }

        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
