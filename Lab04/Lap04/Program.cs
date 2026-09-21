namespace Lap04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW ADVENTURE        |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Player name:");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"welcome, {playerName}. Your journey begins now!\"");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Value input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|     CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your hero"); // แค่ titlr , WriteLine การพิมพ์ขึ้นบรรทัดใหม่
            string CharName = Console.ReadLine();
            Console.Write("Chosse a class (1-3)"); 
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("String luck (0.0 - 1.0):");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{CharName} the Class-{classNum}adventurer enters the dungeon. Luck: {luck}");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");

        }
    }
}
