using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualRevenue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yılın ilk çeyreğindeki toplam gelirinizi giriniz");
            int birinci_ceyrek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yılın ikinci çeyreğindeki toplam gelirinizi giriniz");
            int ikinci_ceyrek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yılın üçüncü çeyreğindeki toplam gelirinizi giriniz");
            int ucüncu_ceyrek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("yılın dördüncü çeyreğindeki toplam gelirinizi giriniz");
            int dorduncu_ceyrek = (Convert.ToInt32(Console.ReadLine()));

            int sonuc = (birinci_ceyrek + ikinci_ceyrek + ucüncu_ceyrek + dorduncu_ceyrek) / 12;
            Console.WriteLine("Aylık Ortalama Kazancınıza Göre;");

            if (sonuc >= 50000 && sonuc < 1000000)
            {
                Console.WriteLine("Tebrikler Bir Altın Çileksiniz");

            }
            else if (sonuc >= 30000 && sonuc < 50000)
            {
                Console.WriteLine("Tebrikler Bir Avakadosunuz");

            }

            else if (sonuc >= 10000 && sonuc < 30000)
            {
                Console.WriteLine("Tebrikler Şirin Bir Lahanasınız");

            }
            else
            {
                Console.WriteLine("Tebrikler Koca Bir Patatessiniz");


            }
            Console.ReadLine();

        }

    }
}
