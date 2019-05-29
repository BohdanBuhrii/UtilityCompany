using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class StringHelper
    {
        public static string ToString(decimal number)
        {
            return number.ToString().Replace(',', '.');
        }

        public static string ToString(long[] array)
        {
            return "'{"+string.Join(", ",array)+"}'";
        }
    }
}
