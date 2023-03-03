using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi;
            Console.Write("sayıyı giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("sayının üste yuvarlanmış hali: " + Math.Ceiling(sayi));
            Console.WriteLine();
            Console.Write("sayının alta yuvarlanmış hali: " + Math.Floor(sayi));
            Console.WriteLine();
            Console.Write("5. kuvveti: " + Math.Pow(sayi, 5));
            Console.Read();
        }
    }
}
