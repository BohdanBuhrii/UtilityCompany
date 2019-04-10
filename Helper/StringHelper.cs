using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class StringHelper
    {
        public static string ToString(object number)
        {
            return number.ToString().Replace(',', '.');
        }
    }
}
