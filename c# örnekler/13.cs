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
            string s;
            int a, b, c;
            Console.Write("1.say�y� giriniz");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("2.say�y� giriniz");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.Write("3.say�y� giriniz");
            s = Console.ReadLine();
            c = Int32.Parse(s);

            if (a >=b && a>= c)
            {
                Console.WriteLine("en b�y�k:" + a);
            }
            else if (b >= c)
            {
                Console.WriteLine("en b�y�k:" + b);
            }
            else
            
                Console.WriteLine("en b�y�k:" + c);
        
            Console.ReadLine();

        }
    }
}
