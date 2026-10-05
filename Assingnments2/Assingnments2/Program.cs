/* Name: Kawinyarat Sakprapakorn
 * Student ID: 1690701196
 * No. 8
 *Section: GI113
 */

namespace Assingment2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Silver";
            const double SmeltRate = 0.64;
            const float SalvageRate = 1.55f;
            const int MaxBatch = 500;

            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║            ⚒ WELCOME TO THE FORGE  ⚒         ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine("║                                              ║");
            Console.WriteLine($"║  MATERIAL : {MaterialName}                           ║");
            Console.WriteLine("║                                              ║");
            Console.WriteLine($"║  Smelting Rate :  {SmeltRate:F2}                       ║");
            Console.WriteLine($"║  Salvage Rate  :  {SalvageRate:F2}                       ║");
            Console.WriteLine("║                                              ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine("║                 FORGE MENU                   ║");
            Console.WriteLine("║                                              ║");
            Console.WriteLine("║   [S]  Smelt:   Ore  →  Ingot                ║");
            Console.WriteLine("║                                              ║");
            Console.WriteLine("║   [B]  Breakdown:   Ingot  →  Ore            ║");
            Console.WriteLine("║                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            Console.Write("Choose Menu:");
            char.TryParse(Console.ReadLine(), out char menu);

            

            Console.Write($"How much would you like (Max{MaxBatch}) :");

            double.TryParse(Console.ReadLine(), out double amount);

            if (amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double outPut = amount * SmeltRate;
                    Console.WriteLine($"{amount:F2} {MaterialName} Ore = {outPut:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double outPut = amount / SalvageRate; 
                    Console.WriteLine($"{amount:F2} {MaterialName} Ingot = {outPut:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" => Error Please Enter S for Smelt B for Breakdown.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" => Error invalid amount.");
            }
        }
    }
}
