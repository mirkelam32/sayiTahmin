using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double sayi1, sayi2;
            string islemAdi;

            Console.WriteLine(" Birinci sayı: " );
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" İkinci sayı: " );
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" İşlemler: Toplamak: (+) Çıkartmak: (-) Çarpmak: (*) Bölmek: (/)");
            islemAdi = Console.ReadLine();

            if (islemAdi == "+")
            {
                Console.WriteLine("İşlemin sonucu:" + sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
            }
           else if (islemAdi == "-")
            {
                Console.WriteLine("İşlemin sonucu:" + sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
            }
          else if (islemAdi == "*")
            {
                Console.WriteLine("İşlemin sonucu:" + sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
            }
           else if (islemAdi == "/")
            {
                Console.WriteLine("İşlemin sonucu:" + sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı işlem yaptınız..!");
            }
            Console.Read();

        }
        
        
    }
}
