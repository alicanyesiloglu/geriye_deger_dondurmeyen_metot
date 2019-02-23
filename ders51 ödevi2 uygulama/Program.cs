using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders51_ödevi2_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            pratik prt = new pratik();
            string ad, bolum;
            int dogum,kacgirisli;
           

            Console.Write("Adınızı girin:");
            ad = Console.ReadLine();

            Console.Write("Bolumunuz");
            bolum = Console.ReadLine();

            Console.Write("Dogum Tarihiniz:");
            dogum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kacgirislisiniz");
            kacgirisli = Convert.ToInt32(Console.ReadLine());

            prt.aslan(ad, bolum, kacgirisli,dogum);
            Console.ReadLine();

        }
    }
}
