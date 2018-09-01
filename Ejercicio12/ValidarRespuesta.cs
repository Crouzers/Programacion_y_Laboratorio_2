using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool ret = false;
            c = char.Parse(Console.ReadLine());

            if (c == 's'||c=='S')
            {
                ret = true;
            }

            return ret;
        }

    }
}
