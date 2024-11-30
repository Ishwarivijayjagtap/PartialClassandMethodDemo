using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    public static class Calcutor
    {
        public static int Multiply(this Calculation c1,int a,int b)
        {
            return a * b;
        }
          
    }
}
