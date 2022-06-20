using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioNS
{
    public static class ExtensionString
    {
        public static bool EsValido(this string x)
        {
            if (x.Length < 50 && !string.IsNullOrEmpty(x))
                return true;

            else
                return false;
        }
    }
}
