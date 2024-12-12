using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararyYapilariAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba");

            Console.Write("Giriş için kullanici kodlari giriniz");
            string kullaniciKod = Console.ReadLine();

            if (kullaniciKod == "ABC" || kullaniciKod == "123" || kullaniciKod == "236" || kullaniciKod == "CMK")
            {
                Console.WriteLine("Kullanici Girişi Başarili");
            }
            else if (kullaniciKod == "HHH" || kullaniciKod == "BBB" || kullaniciKod == "MMM")
            {
                Console.WriteLine("Kullanici girişi kilitlendi.");
            }
            else
            {
                Console.WriteLine("Hatali Kod verdiniz.");
            }
        }
    }
}
