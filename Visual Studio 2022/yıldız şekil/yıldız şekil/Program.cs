using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yıldız_şekil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("baklava dilim sayısı: ");
            int deger;
            deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= deger; i++)
            {
                for (int x = deger; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            for (int k = 1; k <= deger; k++)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write(" ");
                }
                for (int n = deger; n > k; n--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            
            
            Console.Read();


        }
    }
}
