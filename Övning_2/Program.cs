
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

}

    //Menyval 2 Beräknar totalpris för ett sällskap
    static void CalculateGroupTickets()
    {
       
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


