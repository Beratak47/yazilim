using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Lütfen mevsimi küçük harflerle giriniz");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "yaz": Console.Write("yaz mevsimi ayları: Haziran Temmuz Ağustos");
                    break;
                case "sonbahar": Console.Write("sonbahar mevsim ayları: eylül ekim kasım");
                    break;
                case "kış": Console.Write("kış mevsımı ayları Aralık ocak şubat");
                    break;
                case "ilkbahar": Console.Write("ilkbahar ayları Mart nisan mayıs");
                    break;
                default: Console.Write("hatalı mevsim girişi");
                    break;
            }
            Console.ReadLine();
        }
    }
}
