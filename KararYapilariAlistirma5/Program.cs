using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Kodu");
            string KullaniciKodu = Console.ReadLine();

            switch(KullaniciKodu)
            {
                case "AA":
                    Console.WriteLine("Admin Yetkisine Sahipsiniz");
                    break;
                case "BB":
                    Console.WriteLine("Admin Yetkisine Sahipsiniz");
                    break;
                case "CC":
                    Console.WriteLine("Admin Yetkisine Sahipsiniz");
                    break;
                case "DD":
                    Console.WriteLine(" Güçlü Yetkisine Sahipsiniz");
                    break;
                case "FF":
                    Console.WriteLine("Standart Yetkisine Sahipsiniz");
                    break;
                case "EE":
                    Console.WriteLine("Standart Yetkisine Sahipsiniz");
                    break;
                case "GG":
                    Console.WriteLine("Standart Yetkisine Sahipsiniz");
                    break;
                default:
                    Console.WriteLine("Hatalı Kullanıcı Kodu");
                    break;
            }

        }
    }
}
