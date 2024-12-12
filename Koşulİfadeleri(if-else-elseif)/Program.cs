using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koşulİfadeleri_if_else_elseif_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("Sayı 1 degeri giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sayı 2 degerini giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = sayi1 + sayi2;

            if(toplam > 50)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyüktür.");
            }
            else
            {
                Console.WriteLine("Girmiş oldugunuz değerlerin toplamı 50 den küçüktür.");
            }
        }
    }
}
