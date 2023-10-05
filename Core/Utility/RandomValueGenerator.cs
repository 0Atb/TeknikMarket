using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utility
{
    public class RandomValueGenerator
    {
        public static string UniqueFileName(string extesion)
        {
            return Guid.NewGuid().ToString().Replace("-","") + extesion;
        }

        public static string DateFileName(string extension)
        {
            return DateTime.Now.Ticks.ToString();
        }
          
    }
}
