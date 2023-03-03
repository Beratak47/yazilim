using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınavort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.Write("ismim ve soyisminizi giriniz: ");
            isim = Console.ReadLine();

            if (isim=="Berat Akyıldız")
            {
                Console.Write("Öğrencinin sınavları: sınav1= 60 sınav2 = 100 ort= 80");
            }
            else
            {
                Console.Write("yanlış isim girişi tekrar deneyiniz");
            }

            Console.ReadLine();
        }
    }
}
