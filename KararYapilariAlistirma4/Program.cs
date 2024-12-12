using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Merhaba Not Ortalama Hesaplama Sistemine Hoşgeldiniz *******************");

            Console.WriteLine("Lütfen isim ve Soyisim Giriniz : ");
            string adSoyad = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Lütfen 3 Adet Notunuzu Giriniz");

            Console.Write("Lütfen 1. Notunuzu Giriniz : ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Lütfen 2. Notunuzu Giriniz : ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Lütfen 3. Notunuzu Giriniz : ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            double notOrtalama = (double) (not1 + not2 + not3) / 3;

            if(notOrtalama < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if(notOrtalama == 45 || notOrtalama < 70)
            {
                Console.WriteLine("Orta ile geçtiniz");
            }
            else if (notOrtalama == 70 || notOrtalama < 90)
            {
                Console.WriteLine("iyi ile geçtiniz");
            }
            else if (notOrtalama == 90 || notOrtalama <= 100)
            {
                Console.WriteLine("Başarılı Tebrikler");
            }
            else
            {
                Console.WriteLine("Lütfen Notlarınızı Kontrol Edin");
            }
        }
    }
}
