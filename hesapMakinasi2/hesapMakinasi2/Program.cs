using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3;
            string birinciIslem, ikinciIslem;

            Console.WriteLine("Birinci sayıyı yazınız: (Tam Sayı) Örnek: 3");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı yazınız: (Tam Sayı) Örnek: 7");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı yazınız: (Tam Sayı) Örnek: 13");
            sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Birinci ve ikinci işlemleri seçiniz: Toplamak ( + ) Çıkartmak ( - ) Bölmek ( / ) Çarpmak ( * )");
            Console.WriteLine("birinci işlemi yazınız.");
            birinciIslem = Console.ReadLine();
            Console.WriteLine("ikinci işlemi yazınız.");
            ikinciIslem = Console.ReadLine();


            if (birinciIslem == "%" && ikinciIslem == "%")
            {
                Console.WriteLine("Sonuc: " + birinciIslem + " fark " + ikinciIslem + " fark " + (sayi1 % sayi2 % sayi3));
            }
            if (birinciIslem == "+" && ikinciIslem == "+")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " + " + sayi2 + " + " + sayi3 + " = " + (sayi1 + sayi2 + sayi3));
            }
            else if (birinciIslem == "-" && ikinciIslem == "-")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " - " + sayi2 + " - " + sayi3 + " = " + (sayi1 - sayi2 - sayi3));
            }
            else if (birinciIslem == "/" && ikinciIslem == "/")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " / " + sayi2 + " / " + sayi3 + " = " + (sayi1 / sayi2 / sayi3));
            }
            else if (birinciIslem == "*" && ikinciIslem == "*")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " * " + sayi2 + " * " + sayi3 + " = " + (sayi1 * sayi2 * sayi3));
            }

            if (birinciIslem == "+" && ikinciIslem == "-")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " + " + sayi2 + " - " + sayi3 + " = " + (sayi1 + sayi2 - sayi3));
            }
            else if (birinciIslem == "+" && ikinciIslem == "/")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " + " + sayi2 + " / " + sayi3 + " = " + (sayi1 + sayi2 / sayi3));
            }
            else if (birinciIslem == "+" && ikinciIslem == "*")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " + " + sayi2 + " * " + sayi3 + " = " + (sayi1 + sayi2 * sayi3));
            }

            if (birinciIslem == "-" && ikinciIslem == "+")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " - " + sayi2 + " + " + sayi3 + " = " + (sayi1 - sayi2 + sayi3));
            }
            else if (birinciIslem == "-" && ikinciIslem == "/")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " - " + sayi2 + " / " + sayi3 + " = " + (sayi1 - sayi2 / sayi3));
            }
            else if (birinciIslem == "-" && ikinciIslem == "*")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " - " + sayi2 + " * " + sayi3 + " = " + (sayi1 - sayi2 * sayi3));
            }

            if (birinciIslem == "/" && ikinciIslem == "+")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " / " + sayi2 + " + " + sayi3 + " = " + (sayi1 / sayi2 + sayi3));
            }
            else if (birinciIslem == "/" && ikinciIslem == "-")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " / " + sayi2 + " - " + sayi3 + " = " + (sayi1 / sayi2 - sayi3));
            }
            else if (birinciIslem == "/" && ikinciIslem == "*")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " / " + sayi2 + " * " + sayi3 + " = " + (sayi1 / sayi2 * sayi3));
            }

            if (birinciIslem == "*" && ikinciIslem == "+")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " * " + sayi2 + " + " + sayi3 + " = " + (sayi1 * sayi2 + sayi3));
            }
            else if (birinciIslem == "*" && ikinciIslem == "-")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " * " + sayi2 + " - " + sayi3 + " = " + (sayi1 * sayi2 - sayi3));
            }
            else if (birinciIslem == "+" && ikinciIslem == "*")
            {
                Console.WriteLine(" Sonuc: " + sayi1 + " * " + sayi2 + " / " + sayi3 + " = " + (sayi1 * sayi2 / sayi3));
            }else
            {
                Console.WriteLine("Hatalı işlem yaptınız.!");
            }
            Console.ReadLine();

        }
    }
}
