using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            uçak uck = new uçak();
            uck.MARKA = "THY";
            uck.KALKIS = "new york";
            uck.VARIS = "ATATÜRK havalimanı";
            uck.ADI = "Berat";
            uck.SOYADI = "akyıldız";
            uck.YAS = 20;
            uck.CİNSİYET = "erkek";
            Console.WriteLine("Firma adı: " + uck.MARKA);
            Console.WriteLine("Kalkış yeri: " + uck.KALKIS);
            Console.WriteLine("Varış yeri: " + uck.VARIS);
            Console.WriteLine("Yolcu adı: " + uck.ADI);
            Console.WriteLine("Yolcu soyadı: " + uck.SOYADI);
            Console.WriteLine("Yolcu yaşı: " + uck.YAS);
            Console.WriteLine("Yolcu cinsiyeti: " + uck.CİNSİYET);
            Console.Read();
        }
    }
}
