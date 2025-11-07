
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n---HUVUDMENU---");
            Console.WriteLine("1: Pris för en person");
            Console.WriteLine("2: Pris för ett sällskap");
            Console.WriteLine("3: Upprepa text 10 gånger");
            Console.WriteLine("4: Hämta tredje ordet");
            Console.WriteLine("0: Avsluta");

            Console.Write("Välj ett alternativ: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CalculateSingleTicket();
                    break;
                case "2":
                    CalculateGroupTickets();
                    break;
                case "3":
                    RepeatText();
                    break;
                case "4":
                    GetThirdWord();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }

    //Hjälp metod för att returnera priset
    static int GetTicketPrice(int age)
    {
        //Antar att den maximala åldern för biobesökare är 120 år (:
        if (age < 0 || age > 120)
            return -1; // ogiltig ålder
        else if ((age >= 0 && age < 5) || (age > 100 && age <= 120))
            return 0; // gratis inträde
        else if (age < 20)
            return 80; //ungdomspris
        else if (age > 64)
            return 90; //pensionärspris
        else
            return 120; //standard

    }

    // Menyval 1 Beräknar pris för en person baserat på ålder
    static void CalculateSingleTicket()
    {
        int age = -1;
        // Frågar tills användaren anger en giltig ålder
        while (true)
        {
            Console.Write("Ange din ålder: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                int price = GetTicketPrice(age);
                if (price == -1)
                    Console.WriteLine("Ogiltig ålder.");
                else
                {
                    if (price == 0) Console.WriteLine("Gratis onträde!");
                    else Console.WriteLine($"Biljettpris: {price}kr");
                    break;
                }
            }
            else
                Console.WriteLine("Ogiltig ålder. Ange ett heltal.");
        }

    }


    //Menyval 2 Beräknar totalpris för ett sällskap
    //Fortfarande inte bra, för lång
    static void CalculateGroupTickets()
    {
        int total = 0;
        int groupSize = 0;
        // Frågar tills användaren anger en giltig antal
        while (true)
        {
            Console.Write("Hur många personer är ni? ");
            if (int.TryParse(Console.ReadLine(), out groupSize) && groupSize > 0)
                break;
            else
                Console.WriteLine("Ogiltigt antal. Försök igen.");
        }

        //Loopar igenom varje person i sällskapet för att få veta åldern
        //Börjar från 1 (första person), inte 0
        for (int i = 1; i <= groupSize; i++)
        {

            int age = -1;
            // Frågar tills användaren anger en giltig ålder (0–120)
            while (true)
            {
                Console.Write($"Person {i}, ange ålder: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 120)
                {
                    int price = GetTicketPrice(age);

                    if (price == -1)
                        Console.WriteLine("Ogiltig ålder.");
                    else
                    {
                        total += price;
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


    //Menyval 3 Upprepar text 10 gånger på samma rad
    static void RepeatText()
    {
        Console.WriteLine("Ange en text att upprepa: ");
        string input = Console.ReadLine()!;
        for (int i = 1; i <= 10; i++)
        { 
            Console.Write($"{i}.{input} ");
        }
    }

    //Menuval 4 Hämtar det tredje ordet från en mening
    static void GetThirdWord()
    {
        while(true)
        { 
        Console.WriteLine("Ange en mening med minst 3 ord: ");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Du måste skriva något.");
                continue;
            }
            var words = input.Split(" ");
            if (words.Length < 3)
            {
                Console.WriteLine("Meningen måste innehålla minst tre ord");
            }
            else
            {
                Console.WriteLine($"Det tredje ordet är {words[2]}");
                break;

            }

        }
    }












}


