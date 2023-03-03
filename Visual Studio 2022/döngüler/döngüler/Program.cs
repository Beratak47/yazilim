using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Faktöriyeli alınıcak sayıyı giriniz: ");
            sayı = Convert.ToInt16(Console.ReadLine());
            int faktorıyel = 1; 
            while (sayı > 1)
            {
                faktorıyel = faktorıyel * sayı;
                sayı--;
            }
            Console.Write(faktorıyel);
            
            
            
            Console.Read();
        }
    }
}
