using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emlak eml = new emlak();
            eml.SEMTİ = "beykoz";
            eml.RENGİ = "Sarı";
            eml.ODASAYISI = 4;
            eml.KATNO = 8;
            eml.ALAN = 80;
            Console.WriteLine("Evin bulunduğu semt: " + eml.SEMTİ);
            Console.WriteLine("Evin dış rengi: " + eml.RENGİ);
            Console.WriteLine("Evin toplam oda sayısı: " + eml.ODASAYISI);
            Console.WriteLine("Evin numarası: " + eml.KATNO);
            Console.WriteLine("Evin alanı: " + eml.ALAN);
            Console.WriteLine("*************");
            eml.SEMTİ = "Kadıköy";
            eml.RENGİ = "SARI VE LACİVERT";
            eml.ODASAYISI = 54;
            eml.KATNO = 858;
            eml.ALAN = 8000;
            Console.WriteLine("Evin bulunduğu semt: " + eml.SEMTİ);
            Console.WriteLine("Evin dış rengi: " + eml.RENGİ);
            Console.WriteLine("Evin toplam oda sayısı: " + eml.ODASAYISI);
            Console.WriteLine("Evin numarası: " + eml.KATNO);
            Console.WriteLine("Evin alanı: " + eml.ALAN);
            Console.Read();
        }
    }
}
