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
            uint amountOf500Notes = 0;
            uint amountOf100Notes = 0;
            uint amountOf50Notes = 0;
            uint amountOf20Notes = 0;
            uint amountOf10Coins = 0;
            uint amountOf5Coins = 0;
            uint amountOf1Coins = 0;

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

           

            moneyBack = recievedAmount - (uint)total;

            if (moneyBack / 500 >= 1)
            {
                Console.WriteLine("Antalet 500-lappar: " + moneyBack / 500);
                moneyBack %= 500;
            }
            if (moneyBack / 100 >= 1)
            {
                Console.WriteLine("Antalet 100-lappar: " + moneyBack / 100);
                moneyBack %= 100;
            }
            if (moneyBack / 50 >= 1)
            {
                Console.WriteLine("Antalet 50-lappar: " + moneyBack / 50);
                moneyBack %= 50;
            }
            if (moneyBack / 20 >= 1)
            {
                Console.WriteLine("Antalet 20-lappar: " + moneyBack / 20);
                moneyBack %= 20;
            }
            if (moneyBack / 10 >= 1)
            {
                Console.WriteLine("Antalet 10-kronor: " + moneyBack / 10);
                moneyBack %= 10;
            }
            if (moneyBack / 5 >= 1)
            {
                Console.WriteLine("Antalet 5-kronor: " + moneyBack / 5);
                moneyBack %= 5;
            }
            if (moneyBack / 1 >= 1)
            {
                Console.WriteLine("Antalet 1-kronor: " + moneyBack / 1);
                moneyBack %= 1;
            }



            //Skriv ut antal sedlar
        }
    }
}
