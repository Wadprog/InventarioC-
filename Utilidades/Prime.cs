using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Utilidad
    {
        public static bool Primo(int n)
        {
            if (n <= 1) return false;

            for(int i=2; i<n; i++)
            {
                if (n % i == 0) return false;

            }
            return true;

        }

        public static class ValidaForm
        {
            public static bool ValiForm(Control objp, ErrorProvider ep)
            {
                foreach (Control item in )
                {
                    if (objp.Controls.Count > 0)
                    {

                    }
                }
                return true;
            }
        }

    }
}
