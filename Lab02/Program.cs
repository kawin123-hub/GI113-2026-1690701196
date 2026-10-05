/*
 * Student ID :Kawinyarat Sakprapakorn
 * Name       :Lab02
 * Section    :129B
 * No.        :8
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string bossName = "Kirin";
           char rank = 'S';
           int level = 7;   
           int maxHp = 240;
           int currentHp = 175;
           float attackPower = 42.5f;
           double critMultiplier = 1.75;
           bool isBoss = true; 

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damages!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            
            // Part B
            string playerName1 = "BigfatUsagi";
            char rank1 = 'S';
            int level1 = 999;
            int maxHp1 = 999;
            int currentHp1 = 899;
            float attackPower1 = 999.9f;
            double critMultiplier1 = 4.5;
            bool isBoss1 = false;

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"NAME: {playerName1}");
            Console.WriteLine($"RANK: {rank1}");
            Console.WriteLine($"LEVEL: {level1}");
            Console.WriteLine($"HP: {currentHp1} / {maxHp1}");
            Console.WriteLine($"ATTACK POWER: {attackPower1}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier1}");
            Console.WriteLine($"IS BOSS: {isBoss1}");
            Console.WriteLine();

            string playerName2 = "Chiikawa";
            char rank2 = 'B';
            int level2 = 15;
            int maxHp2 = 250;
            int currentHp2 = 200;
            float attackPower2 = 30.5f;
            double critMultiplier2 = 1.25;
            bool isBoss2 = false;

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"NAME: {playerName2}");
            Console.WriteLine($"RANK: {rank2}");
            Console.WriteLine($"LEVEL: {level2}");
            Console.WriteLine($"HP: {currentHp2} / {maxHp2}");
            Console.WriteLine($"ATTACK POWER: {attackPower2}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier2}");
            Console.WriteLine($"IS BOSS: {isBoss2}");
            Console.WriteLine();

            string playerName3 = "rakko";
            char rank3 = 'S';
            int level3 = 300;
            int maxHp3 = 500;
            int currentHp3 = 300;
            float attackPower3 = 79.9f;
            double critMultiplier3 = 2.5;
            bool isBoss3 = false;

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"NAME: {playerName3}");
            Console.WriteLine($"RANK: {rank3}");
            Console.WriteLine($"LEVEL: {level3}");
            Console.WriteLine($"HP: {currentHp3} / {maxHp3}");
            Console.WriteLine($"ATTACK POWER: {attackPower3}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier3}");
            Console.WriteLine($"IS BOSS: {isBoss3}");
            Console.WriteLine();

            string playerName4 = "Hachiware";
            char rank4 = 'B';
            int level4 = 60;
            int maxHp4 = 300;
            int currentHp4 = 150;
            float attackPower4 = 50.5f;
            double critMultiplier4 = 1.5;
            bool isBoss4 = false;

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"NAME: {playerName4}");
            Console.WriteLine($"RANK: {rank4}");
            Console.WriteLine($"LEVEL: {level4}");
            Console.WriteLine($"HP: {currentHp4} / {maxHp4}");
            Console.WriteLine($"ATTACK POWER: {attackPower4}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier4}");
            Console.WriteLine($"IS BOSS: {isBoss4}");
            Console.WriteLine();
        }
    }
}
