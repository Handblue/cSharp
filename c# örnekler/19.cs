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

            int i=0;
            while (i < 1000)
            {
                i += 5;
                Console.Write("{0,5}",i);
                if (i%50==0)
                    Console.ReadLine();

            }
           

        }
    }
}
