using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraYapilariAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Menü");
            Console.WriteLine(" 1- Toplama: ");
            Console.WriteLine(" 2- Çıkarma: ");
            Console.WriteLine(" 3- Çarpma: ");
            Console.WriteLine(" 4- Bölme: ");
            Console.WriteLine(" Seciniz: ");
            string menu = Console.ReadLine();

            Console.Clear();

            int sayi1 = 0;
            int sayi2 = 0;
            int sonuc = 0;



            if (menu == "1" ||menu == "2" || menu=="3" || menu=="4")
            {
                Console.Write("1. Sayi değerini Giriniz : ");
                 sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. Sayi değerini Giriniz : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

            }
            else 
            {
                Console.WriteLine("Yanlış Secim yaptınız.");
            }
            

            if (menu == "1")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("SONUC : " + sonuc);
            }
            else if(menu == "2")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("SONUC : " + sonuc);
            }
            else if (menu == "3")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("SONUC : " + sonuc);
            }
            else if (menu == "4")
            {
                if(sayi1 == 0)
                {
                    Console.WriteLine("bölen sıfır olamaz");
                }
                else
                {
                    sonuc = sayi1 / sayi2;

                    Console.WriteLine("SONUC : " + sonuc);
                }
            }
        }
    }
}
