using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public class Validar
    {

        public static bool ValidacionTextBox(Control Objeto, ErrorProvider error)
        {
            bool verificado = false;
            foreach (Control item in Objeto.Controls)
            {
                if (item is textbox)
                {
                    textbox obj = (textbox)item;
                    if (obj.Validar)
                    {
                        if (obj.Text is null)
                            verificado = true;
                        error.SetError(obj, (string.IsNullOrEmpty(obj.Text.Trim())) ? "Campo Obligatorio" : "");
                    }
                }
                else
                    ValidacionTextBox(item, error);

            }
            return verificado;
        }

        public static void Limpiar(Control Objeto)
        {
            foreach (Control item in Objeto.Controls)
            {
                if (item is textbox)
                {
                    item.Text = "";
                }
                else
                    Limpiar(item);
            }
        }
    }
}
