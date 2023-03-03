using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesli_harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sesli = "a,e,ı,i,o,ü,u "; 
            Console.WriteLine("isim-kelime Giriniz: ");
            string cumle = Console.ReadLine();
            int sayac = 0;
            foreach (var item in cumle)
                foreach (var item2 in sesli)
                {
                    if (item == item2)
                    {
                        sayac++;
                    }
                }
            Console.WriteLine("Sesli Harf Sayısı {0}", sayac);
            

            Console.Read();
        }
    }
}
