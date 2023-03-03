using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Öğrenci not hesaplama ***");
            Console.WriteLine();

            double sınav1, sınav2, sınav3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine();
            Console.WriteLine("*** Öğrenci kimlik bilgileri ***");
            Console.WriteLine();

            Console.Write("Adınız= ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız= ");
            soyad = Console.ReadLine();

            Console.Write("Numaranız= ");
            numara = Console.ReadLine();

            Console.WriteLine("*** Öğrenci sınav bilgileri ***");
            Console.WriteLine();

            Console.Write("Birinci sınav= ");
            sınav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sınav= ");
            sınav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçüncü sınav= ");
            sınav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje= ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*** Ortalama Değeri ****");
            Console.WriteLine();

            ort = (sınav1 + sınav2 + sınav3 + proje) / 4;
            Console.Write("Ad soyad = " + ad + soyad );
            Console.WriteLine();
            Console.Write("numaranız = " + numara);
            Console.WriteLine();

            Console.Write("Ortalama= " + ort);


            Console.Read();
        }
    }
}
