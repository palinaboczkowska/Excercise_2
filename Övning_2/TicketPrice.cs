using System;

namespace Övning_2
{

    public enum TicketPrice 
    {
        Ogiltig = -1,
        Gratis = 0,
        Ungdomspris = 80,
        Pensionärspris = 90,
        Standardpris = 120
    }

    public static class TicketCalculator
        {
        const int MaxGroupSize = 30; //Antar att det är 30 pers max
        const int MaxAge = 120; //Antar att den maximala åldern för biobesökare är 120 år (:


        //Hjälpmetod för att returnera biljettpris baserat på ålder
        public static TicketPrice GetTicketPrice(int age)
        {
            
            if (age < 0 || age > MaxAge)
                return TicketPrice.Ogiltig;
            else if ((age >= 0 && age < 5) || (age > 100 && age <= MaxAge))
                return TicketPrice.Gratis;
            else if (age < 20)
                return TicketPrice.Ungdomspris;
            else if (age > 64)
                return TicketPrice.Pensionärspris;
            else
                return TicketPrice.Standardpris;

        }



        // Undermenyval 1 Beräknar pris för en person baserat på ålder
        public static void CalculateSingleTicket()
        {
            int age = -1;
            //Frågar tills användaren anger en giltig ålder
            while (true)
            {
                Console.Write("Ange din ålder: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    TicketPrice price = GetTicketPrice(age); //hämtar pris
                    if (price == TicketPrice.Ogiltig)
                        Console.WriteLine("Ogiltig ålder.");
                    else
                    {
                        if (price == TicketPrice.Gratis) Console.WriteLine("Gratis inträde!");
                        else Console.WriteLine($"{price}: {(int)price}kr");
                        break;
                    }
                }
                else
                    Console.WriteLine("Ogiltig ålder. Ange ett heltal.");


                //Implementationen med nästlad if-sats och utan hjälpmetod
                //Console.Write("Ange ålder: ");
                //if (int.TryParse(Console.ReadLine(), out int age))
                //{
                //    if (age >= 0 && age <= 120)
                //    {
                //        if (age < 20)
                //            Console.WriteLine("Ungdomspris: 80kr");
                //        else
                //        {
                //            if (age > 64)
                //                Console.WriteLine("Pensionärspris: 90kr");
                //            else
                //                Console.WriteLine("Standardpris: 120kr");
                //        }
                //    }
                //    else
                //        Console.WriteLine("Ogiltig ålder.");
                //}
                //else
                //    Console.WriteLine("Ogiltig ålder. Ange ett heltal.");
            }

        }


        //Undermenyval 2 Beräknar totalpris för ett sällskap
        //Fortfarande inte bra, för lång
        public static void CalculateGroupTickets()
        {
            int total = 0; //totalkostnaden för gruppen
            int groupSize = 0; //antal personer
                               // Frågar tills användaren anger en giltig antal
            while (true)
            {
                Console.Write("Hur många personer är ni? ");
                if (int.TryParse(Console.ReadLine(), out groupSize) && groupSize > 0 && groupSize <= MaxGroupSize )
                    break;
                else
                    Console.WriteLine("Ogiltigt antal. Försök igen.");
            }

            //Loopar igenom varje person i sällskapet för att få veta åldern
            //Börjar från 1 (första person), inte 0 - för utskrift
            for (int i = 1; i <= groupSize; i++)
            {

                int age = -1;
                // Frågar tills användaren anger en giltig ålder (0–120)
                while (true)
                {
                    Console.Write($"Person {i}, ange ålder: ");
                    if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= MaxAge)
                    {
                        TicketPrice price = GetTicketPrice(age); //hämtar pris

                        if (price == TicketPrice.Ogiltig)
                            Console.WriteLine("Ogiltig ålder.");
                        else
                        {
                            total += (int)price; //explicit cast behövs här om man använder Enum för priser
                            break; // Gå vidare till nästa person
                        }
                    }
                    else
                        Console.WriteLine("Ogiltigt ålder. Försök igen.");
                }

            }
            Console.WriteLine($"Antal personer: {groupSize}");
            Console.WriteLine($"Totalkostnad för hela sällskapet: {total}kr");
        }
    }
}
