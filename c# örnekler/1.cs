using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeone
{
    class Program
    {
        static void Main(string[] args)
        {
            object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "B";
            Console.WriteLine(x.GetType());
            x = 8.78F;
            Console.WriteLine(x.GetType());
            Console.ReadLine();
        }
    }
}
