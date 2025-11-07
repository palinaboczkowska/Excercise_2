
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

    // Menyval 1 Beräknar pris för en person baserat på ålder
    static void CalculateSingleTicket()
    {
        Console.Write("Ange din ålder: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if ((age >= 0 && age < 5) || (age > 100 && age < 120)) Console.WriteLine("Gratis inträde!");
            else if (age < 0 || age > 120) Console.WriteLine("Ogiltig ålder.");
            else if (age < 20) Console.WriteLine("Ungdompris: 80kr");
            else if (age > 64) Console.WriteLine("Pensionärspris: 90 kr");
            else Console.WriteLine("Standardpris: 120");
        }
        else
            Console.WriteLine("Ogiltig ålder. Ange ett heltal.");
    }


    //Menyval 2 Beräknar totalpris för ett sällskap
    //Inte bra än, hitta en mer kompakt lösning
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
                    if ((age >= 0 && age < 5) || (age > 100 && age < 120))
                        break;
                    else if (age < 0 || age > 120) Console.WriteLine("Ogiltig ålder.");
                    else if (age < 20)
                    {
                        total += 80;
                        break;
                    }
                    else if (age > 64)
                    {
                        total += 90;
                        break;
                    }
                    else
                    {
                        total += 120;
                        break;
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

}

//Menuval 4 Hämtar det tredje ordet från en mening
static void GetThirdWord()
{

}












}


