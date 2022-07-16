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
            Console.WriteLine("kaçýmcý sýmnýf");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            switch(a)
            {
                case (1): Console.WriteLine("daha yenisiniz");
                    break;
                case (2):
                    Console.WriteLine("mirasçýsýnýz");
                    break;
                case (3):
                    Console.WriteLine("ev sahibi");
                    break;
                case (4):
                    Console.WriteLine("misafir");
                    break;
                default:
                    Console.WriteLine("siz okulu uzatmýssýnýz");
                    break;

            }
        
            Console.ReadLine();

        }
    }
}
