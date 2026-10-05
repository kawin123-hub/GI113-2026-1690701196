/*
 * Student ID :Kawinyarat Sakprapakorn
 * Name       :Lab06
 * Section    :129B
 * No.        :8
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            int clues = 0;
            int crowns = 125;


            Console.WriteLine("=======================================");
            Console.WriteLine("             LOST CONTRACT             ");
            Console.WriteLine("=======================================");
            Console.WriteLine("Geralt arrives at a village in Velen.");
            Console.WriteLine("A hunter has disappeared without a trace.");
            Console.WriteLine("The villagers believe a monster is nearby.");
            Console.WriteLine();
            Console.WriteLine("What should Geralt investigate first?");
            Console.WriteLine();
            Console.WriteLine("[1] Talk to the herbalist");
            Console.WriteLine("[2] Search the forest");
            Console.WriteLine("[3] Leave the village");
            Console.Write("Your choice: ");

            string? input = Console.ReadLine();
            int choice;
            
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine();
                Console.WriteLine("invalid input, Please enter a number.");
            }
            else if (choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("That choice does not exist.");
            }
            else if (choice == 1)
            {
                
                clues += 1;
                crowns += 10;
                
                Console.WriteLine();
                Console.WriteLine("The herbalist gives Geralt a strange silver pendant.");
                Console.WriteLine("Clue found: Silver pendant.");
                Console.WriteLine("Crowns earned: 10");
                Console.WriteLine();
 
                Console.WriteLine("Where should Geralt go next?");
                Console.WriteLine("[1] Investigate the old mine");
                Console.WriteLine("[2] Search the hunter's cabin");
                Console.WriteLine("[3] Follow the footprints");
                Console.Write("Your choice: ");
                
                string? secondInput = Console.ReadLine();
                int secondChoice;

                if (!int.TryParse(secondInput, out secondChoice))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input, Please enter a number.");
                }
                else if (secondChoice < 1 || secondChoice > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("That location does not exist.");
                }
                else if (secondChoice == 1)
                {
                    clues += 1;
 
                    Console.WriteLine();
                    Console.WriteLine("Geralt enters the old mine.");
                    Console.WriteLine("He finds strange claw marks on the stone wall.");
                    Console.WriteLine("Clue found: Monster tracks.");
                    Console.WriteLine();
                }
                else if (secondChoice == 2)
                {
                    clues += 1;
                    crowns += 20;
 
                    Console.WriteLine();
                    Console.WriteLine("Geralt searches the hunter's cabin.");
                    Console.WriteLine("He finds a broken sword and a map.");
                    Console.WriteLine("Clue found: A map leading into the forest.");
                    Console.WriteLine("Crowns earned: 20");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Geralt follows the footprints.");
                    Console.WriteLine("They fade away in the mud.");
                    Console.WriteLine();
                }

                if (secondChoice >= 1 && crowns >= 3)
                {
                    if (clues >=2 && crowns >= 150)
                    {
                        Console.WriteLine("The evidence is strong enough.");
                        Console.WriteLine("The contract can now be completed.");
                    }
                    else if (clues >= 2)
                    {
                        Console.WriteLine("Geralt now knows where to look.");
                        Console.WriteLine("The monster hunt begins.");
                    }
                    else
                    {
                        Console.WriteLine("The clues are not enough.");
                        Console.WriteLine("The mystery remains unsolved.");
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Geralt searches the forest.");
                Console.WriteLine("He finds nothing useful for now.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Geralt leaves the village.");
                Console.WriteLine("The village must solve the mystery on its own.");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Investigation finished.");
            Console.WriteLine("Clues collected: " + clues);
            Console.WriteLine("Crowns: " + crowns);
            Console.WriteLine("------------------------------------------");
        }
    }
}
