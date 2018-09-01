using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string ret="";
            while (num > 0)
            {
                ret = (num % 2).ToString() + ret;
                num = num / 2;
            }
            return ret;
        }

        public static int BinarioDecimal(string num)
        {
            int ret=0;
            int largo = num.Length;
            int cadenaNumero = int.Parse(num);
            int i;
            for (i = 1; i <= largo; i++)
            {
                ret += int.Parse(num[i - 1].ToString()) * (int)Math.Pow(2, i);
            }
            return ret;
        }

    }
}
