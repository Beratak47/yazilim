using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
    internal class Program
    {
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(bilgi);
        }
        static void Main(string[] args)
        {
            Console.Write("metni girin: ");
            Console.WriteLine();
            string blg = Console.ReadLine();
            yazdir(blg);
            Console.Read();
        }
    }
}
