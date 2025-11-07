
using Övning_2;

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("\n---HUVUDMENU---");
    Console.WriteLine("1: Bio biljettpriser");
    Console.WriteLine("2: Upprepa text 10 gånger");
    Console.WriteLine("3: Hämta tredje ordet");
    Console.WriteLine("0: Avsluta");

    Console.Write("Välj ett alternativ: ");

    string input = Console.ReadLine()!;
    switch (input)
    {
        case "1":
            ShowBioMenu();
            break;
        case "2":
            TextUtilities.RepeatText();
            break;
        case "3":
            TextUtilities.GetThirdWord();
            break;
        case "0":
            isRunning = false;
            break;
        default:
            Console.WriteLine("Ogiltigt val. Försök igen.");
            break;
    }
}


//Menuval 1
void ShowBioMenu()
{
    while (true)
    {
        Console.WriteLine("\n-BIO-");
        Console.WriteLine("1: Pris för en person");
        Console.WriteLine("2: Pris för ett sällskap");
        Console.WriteLine("0: Tillbaka till huvudmenyn");

        Console.Write("Välj ett alternativ: ");
        string input = Console.ReadLine()!;

        switch (input)
        {
            case "1":
                TicketCalculator.CalculateSingleTicket();
                break;
            case "2":
                TicketCalculator.CalculateGroupTickets();
                break;
            case "0":
                return; // tillbaka till huvudmenyn
            default:
                Console.WriteLine("Ogiltigt val. Försök igen.");
                break;
        }
    }
}