using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz:");
                double sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("Toplam={0}", toplam);
            Console.Read();
        }
    }
}
