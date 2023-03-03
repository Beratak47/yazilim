using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int sınav1, sınav2, sınav3, ortalama;
            Console.WriteLine("**** öğrenci bilgi *****");
            Console.WriteLine();
            ad = "Berat";
            soyad = "akyılıdz";
            numara = "341414";

            Console.WriteLine("Ad= " + ad);
            Console.WriteLine("Soyad= " + soyad);
            Console.WriteLine("numara= " + numara);

            Console.WriteLine();
            Console.WriteLine("**** Not bilgileri ****");
            Console.WriteLine();

            sınav1 = 60;
            sınav2 = 100;
            sınav3 = 40;

            Console.WriteLine("sınav1= " + sınav1);
            Console.WriteLine("sınav2= " + sınav2);
            Console.WriteLine("sınav3= " + sınav3);

            Console.WriteLine();
            Console.WriteLine("**** Ortalama Bilgi ****");

            ortalama = (sınav1 + sınav2 + sınav3) / 3;
            Console.WriteLine("ortalama= " + ortalama);


 

            Console.Read();
        }
    }
}
