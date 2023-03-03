using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_orneklerı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, sehir;
            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Sehrinizi girin: ");
            sehir = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Ad: {0} soyad:{1}  sehir:", ad, soyad, sehir);
            Console.Read();
        }
    }
}
