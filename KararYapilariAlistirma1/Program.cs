using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı adını Giriniz : ");
            string KullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz : ");
            string sifre = Console.ReadLine();

            if(KullaniciAdi == "Admin" && sifre == "123")
            {
                Console.WriteLine("Kullanici adi ve şifre doğru Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adi ve şifre hatali Giriş Basarisiz");
            }
        }
    }
}
