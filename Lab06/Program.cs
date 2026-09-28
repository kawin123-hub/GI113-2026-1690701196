/*
 * Student ID :Kawinyarat Sakprapakorn
 * Name       :Lab06
 * Section    :129B
 * No.        :13
 * Course     : GI113 Computer Programming (GI)
 */
using System.Runtime.CompilerServices;

namespace Lab06
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("=== The Witcher 3: Tracking the beats===");
            Console.WriteLine("Geralt fids strange tracks near an abandoned village");
            Console.WriteLine("1. Examine the footprints");
            Console.WriteLine("2. Search the nearby house");
            Console.WriteLine("3. Leave the village");
            Console.Write("Choose an action: ");
            
            string? answer = Console.ReadLine();
            int action;
            if (!int.TryParse(answer, out action))
            {
                Console.WriteLine("Please enter a number.");
            }
            else if (action == 1)
            {
                Console.WriteLine("Geralt examines the footprints.");
                Console.WriteLine("He discovers that the beast went into the forest.");
            }
            else if (action == 2)
            {
                Console.WriteLine("Geralt searches the abandoned house");
                Console.WriteLine("He finds a cule about the missing villagers");
            }
            else
            {
                Console.WriteLine("Geralt leaves the village");
                Console.WriteLine("The monster remains somewhere in the forest");
            }
        }
    }
}
