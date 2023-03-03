using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonsuz_döngü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi >=0 )
            {
                Console.WriteLine("bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            while (sayi <= 0)
            {
                Console.WriteLine("bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
         
            Console.Read();
        }
    }
}
