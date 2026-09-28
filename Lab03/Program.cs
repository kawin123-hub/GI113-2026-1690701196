/*
 * Student ID :Kawinyarat Sakprapakorn
 * Name       :Lab02
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
class Program
 {
    static void Main(string[] args)
    {
        const int MaxLevel = 10;

        var bossName = "Kirin";
        var rank = 'S'; 
        int level = 7;
        int maxHp = 240;
        int currentHp = 115; 
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool iaBoss = true;

        // Boss Stats
        Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
        Console.WriteLine($"NAME: {bossName}" +
         $"\nRANK: {rank}" +
         $"\nLEVEL: {level}" +
         $"\nMAX HP: {maxHp}" +
         $"\nCURRENT HP: {currentHp}" +
         $"\nATTACK POWER: {attackPower}" +
         $"\nCRIT MULTIPLIER: {critMultiplier}" +
         $"\nIS BOSS: {iaBoss}");
         // Implicit conversion HP (int) -->> double
         Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
         double currentHpDouble = currentHp;
         Console.WriteLine($"HP(double): {currentHpDouble}");

         // Calculate the Percentage as double
         Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
         double hpPercent = currentHpDouble / maxHp * 100;
         Console.WriteLine($"HP Percent: {hpPercent:F5}%");

         // Explicit casting attack power (float) -->> int
         // Cast vs. Convert: Crit Multiplier 


    }
 }
}
