using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerReferansParametre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankaKarti bonusKart = new BankaKarti();
            bonusKart.KartNo = "1234";
            bonusKart.Bakiye = 500;

            BankaKarti worldKart = new BankaKarti();
            worldKart.KartNo = "9876";
            worldKart.Bakiye = 10000;

            Console.WriteLine("Bonus Kart");
            Console.WriteLine("Kart No =\t " + bonusKart.KartNo);
            Console.WriteLine("Bakiye =\t " + bonusKart.Bakiye);

            Console.WriteLine("World Kart");
            Console.WriteLine("Kart No =\t " + worldKart.KartNo);
            Console.WriteLine("Bakiye =\t " + worldKart.Bakiye);

            bonusKart.Bakiye = worldKart.Bakiye;
            //bonusKart.KartNo = "1111";
            Console.WriteLine("Değer ataması yapıldı.");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Bonus Kart");
            Console.WriteLine("Kart No =\t " + bonusKart.KartNo);
            Console.WriteLine("Bakiye =\t " + bonusKart.Bakiye);

            Console.WriteLine("World Kart");
            Console.WriteLine("Kart No =\t " + worldKart.KartNo);
            Console.WriteLine("Bakiye =\t " + worldKart.Bakiye);

            bonusKart = worldKart;
            bonusKart.KartNo = "1111";
            Console.WriteLine("Referans ataması yapıldı.");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Bonus Kart");
            Console.WriteLine("Kart No =\t " + bonusKart.KartNo);
            Console.WriteLine("Bakiye =\t " + bonusKart.Bakiye);

            Console.WriteLine("World Kart");
            Console.WriteLine("Kart No =\t " + worldKart.KartNo);
            Console.WriteLine("Bakiye =\t " + worldKart.Bakiye);

            string[] isimler = new string[5];       //RAM'IN STACK KISMINDA REFERANS OLARAK İSİMLERİ AÇTI VE HEAP KISMINA 5 ADET DEĞER AÇTI. isimlerin 0 indexli, 1 indexli eleman vb.

            //BankaKarti qnb = new BankaKarti() { KartNo = "1234", Bakiye = 1234 };

        }
    }
}
