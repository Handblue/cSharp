using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek001
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int i = 0, a, n;

                Console.WriteLine("Bir sayý girin:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("artým miktarý:");
                a = Convert.ToInt32(Console.ReadLine());

            for (; i < n;)
            {
                Console.WriteLine("{0}", i);
                i += a;
            }
            Console.ReadLine();

        }
    }
}
