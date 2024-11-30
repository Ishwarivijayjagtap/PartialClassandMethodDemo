using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    public partial class Cals
    {
        public int Multiply(int a,int b)
        {
            return a * b;
        }
        partial void Divide(int a, int b);
    }
}
