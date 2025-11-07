using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    public static class TextUtilities
    {
        //Menyval 2 Upprepar text 10 gånger på samma rad
        public static void RepeatText()
        {
            Console.WriteLine("Ange en text att upprepa: ");
            string input = Console.ReadLine()!;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{input} ");
            }
        }

        //Menuval 3 Hämtar det tredje ordet från en mening
        public static void GetThirdWord()
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
    }
}
