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


            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma:        ");
                    total = double.Parse(Console.ReadLine());

                    if (total > 0.49)
                    {
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras");
                        Console.ResetColor();
                        return;
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.\n");
                    Console.ResetColor();
                }
            }

            subtotal = (uint)Math.Round(total);
            roundingOffAmount = total - subtotal;

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp:  ");
                    recievedAmount = uint.Parse(Console.ReadLine());

                    if (recievedAmount > total)
                    {
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.\n");
                        Console.ResetColor();
                        return;
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.\n");
                    Console.ResetColor();
                }

            }
            
            //Skriv ut kvitto - börja med totalt
            Console.WriteLine("\nKVITTO\n-------------------------------");
            Console.WriteLine("Totalt        :      {0, 10:c}", total);
            Console.WriteLine("Öresavrundning:      {0, 10:c}", roundingOffAmount);
            Console.WriteLine("Att betala    :      {0, 10:c0}", (uint)subtotal);         //Borde anges utan ören. Hur?
            Console.WriteLine("Kontant       :      {0, 10:c}", recievedAmount);
            moneyBack = recievedAmount - (uint)total;
            //Räkna ut pengar tillbaka från kontantbetalning -- avrundat belopp
            Console.WriteLine("Tillbaka      :      {0, 10:c}", moneyBack);
            Console.WriteLine("-------------------------------");


            //Räkna ut antal sedlar med hjälp av while och %



            moneyBack = recievedAmount - (uint)total;
            uint count = moneyBack / 500;
            if (count >= 1)
            {
                Console.WriteLine("Antalet 500-lappar: {0}", count);
                moneyBack %= 500;
            }
            if (moneyBack / 100 >= 1)
            {
                Console.WriteLine("Antalet 100-lappar: {0}.", moneyBack / 100);
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
