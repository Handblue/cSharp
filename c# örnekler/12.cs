using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddddff
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t;
            int i = 123;
            float f = 23.45F;

            t = typeof(int);
            Console.Write(t.ToString() +"  ");
            Console.WriteLine(i.GetType());

            t = typeof(float);
            Console.Write(t.ToString() +"  ");
            Console.WriteLine(f.GetType());
            Console.ReadLine();



        }
    }
}
