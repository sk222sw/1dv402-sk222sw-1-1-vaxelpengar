using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler
            double subtotal;            
            double roundingOffAmount;   
            double total;               //Ska vara uint enligt instruktioner, men det blir fel när man ska skriva in summan då.
            uint recievedAmount;        //Vad kunden ger kassören
            uint moneyBack;             //Växeln kunden får tillbaka

            //Ta emot data från användare
            Console.Write("Ange totalsumma: ");
            total = double.Parse(Console.ReadLine());
            Console.Write("Ange erhållet belopp: ");
            recievedAmount = uint.Parse(Console.ReadLine());

            //Skriv ut kvitto - börja med totalt
            Console.WriteLine("\nKvitto\n---------------------");
            //Öresavrunda
            subtotal = (uint)Math.Round(total);
            roundingOffAmount = total - subtotal;

            Console.WriteLine("Totalt: {0:c}", total);
            Console.WriteLine("Öresavrundning: {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala: {0:c}", (uint)subtotal);         //Borde anges utan ören. Hur?
            Console.WriteLine("Kontant: {0}", recievedAmount);
            moneyBack = recievedAmount - (uint)total;
            //Räkna ut pengar tillbaka från kontantbetalning -- avrundat belopp
            Console.WriteLine("Tillbaka {0}", moneyBack);
            Console.WriteLine("---------------------");


            //Räkna ut antal sedlar med hjälp av while och %

            //Skriv ut antal sedlar
        }
    }
}
