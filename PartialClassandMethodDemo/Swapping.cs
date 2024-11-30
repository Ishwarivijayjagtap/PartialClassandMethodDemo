using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    public class Swapping
    {
        static void SwapValue(ref int a, ref int b) 
        {
            int temp;
            temp = a; 
            a = b; 
            b = temp;
        }
        static void Cacl(int x, int y, out int add, out int multiply)
        {
            add = x + y;
            multiply = x * y;
        }

        //static void Main(string[] args)
        //{
        //    int a = 10, b = 20;
        //    Console.WriteLine($"Before swap a={a} , b={b}");
        //    SwapValue(ref a, ref b);
        //    Console.WriteLine($"After swap a={a} , b={b}");
        //    int x = 5, y = 7, add, mul; // add & mul are the empty variables
        //    Cacl(x, y, out add, out mul);
        //    Console.WriteLine("add " + add);
        //    Console.WriteLine("multiply " + mul);

        //}

    }

}
