using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    public  partial class Cals
    {
      public int Add(int a,int b) 
        {
            return a + b;
        }
        public void Invoke(int a, int b)
        {
            Divide(a, b);
        }
        partial void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }

}

