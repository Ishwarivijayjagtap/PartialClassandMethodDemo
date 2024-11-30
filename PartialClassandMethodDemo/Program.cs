using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //  Cals c1 = new Cals();
            //    //Console.WriteLine(c1.Add(23,67));
            //    //Console.WriteLine(c1.Multiply(34,70));
            //    //c1.Invoke(20, 2);
            //    //  Employee e1 = new Employee(1, "Isha", Department.Sales, Roles.Employee);
            //    // Console.WriteLine(e1);
            //   // Dept d1 = new Dept(1, "Sales");
            //   // Console.WriteLine(d1.Print());
            //    //var d2 = new Dept(2, "Hr");
            //    //Console.WriteLine(d2.Print());
            Calculation c1 = new Calculation();
          
            Console.WriteLine(c1.Add(44, 90));
            Console.WriteLine(c1.Multiply(23,6));
        


        }
    }
}
