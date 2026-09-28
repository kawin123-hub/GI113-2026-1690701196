/* Name: Kawinyarat Sakprapakorn
 * Student ID: 1690701196
 * No. 13
 *Section: GI113
 */
 namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hero
         Console.WriteLine("==== GAME TITLE====");
         Console.WriteLine("Hero VS. Monster");

         Console.Write("Hero HP: ");
         bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
         Console.Write("Hero Attack: ");
         bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAttack);
         Console.Write("Hero Defense: ");
         bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDefense);

         // Monster
         Console.Write("Monster HP: ");
         bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
         Console.Write("Monster Attack: ");
         bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monsterAttack);
         Console.Write("Monster Defense: ");
         bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monsterDefense);
         
         // Check for vaild input
         bool heroInputValid = heroHpOk && heroAttackOk && heroDefenseOk;
         bool monsterInputValid = monsterHpOk && monsterAttackOk && monsterDefenseOk;
         Console.WriteLine($">> Hero stats valid: {heroInputValid}");
         Console.WriteLine($">> Monster stats valid: {monsterInputValid}");
         Console.WriteLine($"[HERO]      HP: {heroHp}, ATK: {heroAttack}, DEF: {heroDefense}");
         Console.WriteLine($"[MONSTER]   HP: {monsterHp}, ATK: {monsterAttack}, DEF: {monsterDefense}");

         // Hero drink potion before the fight (compond assignment)
         int potionHeal = 10;
         // heroHp = Hero + potionHeal ผลคือ114
         //heroHp += potionHeal ผลคือ 114 การคำนวณเหมือนกัน
         heroHp += potionHeal; //Hero drink HP potion
         Console.WriteLine($"\nHero drink a potion, healing {potionHeal} HP. Hero HP is now {heroHp}.");

         int normalDamage = Math.Max(0, heroAttack - monsterDefense);
         Console.WriteLine($"\nHero deals {normalDamage} damage to the monster.");
         
         int counterDamage = Math.Max(0, monsterAttack - heroDefense);
         Console.WriteLine($"Counter attack deals: {counterDamage} DMG");

         Random randomSomthing = new Random();
         int roll = randomSomthing.Next(1, 101);
         bool isCrit = roll <= 20; 
         int critDamage = Convert.ToInt32(isCrit) * normalDamage;
         Console.WriteLine($"Crit Damage roll: {roll} (Crit?: {isCrit})"); 
         Console.WriteLine($"If critcal, normal attack would deal: {critDamage}");
        }
    }
}