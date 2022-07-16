using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemethere
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("1. sayi :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayi :");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.Write("{0} ve {1} sayısının toplamı : {2}", sayi1, sayi2, toplam);
            Console.ReadLine();

        }
    }
}
