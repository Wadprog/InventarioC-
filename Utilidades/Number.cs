using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Number
    {
        public static string Convertir(int n)
        {
            if (n <= 0 || n > 999) return "";

            String cn = n.ToString().PadLeft(3, '0');

            int c = Convert.ToInt16(cn.Substring(0, 1));
            int d = Convert.ToInt16(cn.Substring(1, 1));
            int u = Convert.ToInt16(cn.Substring(2, 1));
            int u2 = Convert.ToInt16(cn.Substring(1, 2));

            if (n == 100) return "cien";

            String[] vu = new string[] { null, "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve", "veinte", "ventiuno", "ventidos", "ventitres", "venticuatro","venticinco","ventiseis","ventisiete","ventiocho","ventinueve","treinta" };
            String[] vd = new string[] { null, "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            String letras = "";

            if (c > 0) letras += vu[c] + "cientos";

            if (u2 > 0)
            {
                if (u2 <= 30) letras += vu[u2];
                else
                {
                    letras += vd[d];
                    if(u>0)letras+=" y "+vu[u];
                }
            }


            return "";
        }
    }
}
