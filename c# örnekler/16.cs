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
            Console.Write("bir sayý girin");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i <= n; i++)
                toplam = toplam + i;
            {
                Console.WriteLine("1\'den {0}\'e kadar olan sayýlarýn toplamý{1}\'dir", n, toplam);
            }
        
            Console.ReadLine();

        }
    }
}
