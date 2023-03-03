using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.WriteLine("1 ve 7 arası bir sayı giriniz: ");
            sayı = Convert.ToInt16(Console.ReadLine());
            
            switch (sayı)
            {
                case 1: Console.Write("Gün=Pazartesi");
                        break;
                case 2: Console.Write("Gün=Salı");
                    break;
                case 3: Console.Write("Gün=Çarşamba");
                    break;
                case 4: Console.Write("Gün=Perşembe");
                    break;
                case 5: Console.Write("Gün=Cuma");
                    break;
                case 6: Console.Write("Gün=Cumartesi");
                    break;
                case 7: Console.Write("Gün=Pazar");
                    break;
                default: Console.Write("hatalı gün girişi");
                    break;

            }
            Console.ReadLine();
        }
    }
}
