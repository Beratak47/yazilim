using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_bölüüm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Bir sayı giriniz: ");
            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı % 4 == 0 && sayı % 7 == 0)
            {
                Console.WriteLine("Sayı 4 ve 7 ye tam bölünür");
            }
            
            else
            {
                Console.WriteLine("sayı 4 ve 7 ye tam bölünmez");
            }
            Console.ReadLine();
        }
    }
}
