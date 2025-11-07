
using Övning_2;
using System.ComponentModel.Design;

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
            TicketCalculator.CalculateSingleTicket();
            break;
        case "2":
            TicketCalculator.CalculateGroupTickets();
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



//Menyval 3 Upprepar text 10 gånger på samma rad
void RepeatText()
{
    Console.WriteLine("Ange en text att upprepa: ");
    string input = Console.ReadLine()!;
    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{i}.{input} ");
    }
}

//Menuval 4 Hämtar det tredje ordet från en mening
void GetThirdWord()
{
    //Fortsätta tills giltig mening anges
    while (true)
    {
        Console.WriteLine("Ange en mening med minst 3 ord: ");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Du måste skriva något.");
            continue;
        }
        var words = input.Split(" "); // delar upp meningen i ord
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


