using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mat_fonksşyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("mutlak hal: " + Math.Abs(sayi));
            Console.Read();
        }
    }
}
