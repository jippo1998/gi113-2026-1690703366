/*
* Student ID :1690703366
* Name       :เมธปรียา บุญมาวงศ์
* Section    :129D
* No.        :N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------------------------------------+"); 
            Console.WriteLine("|                    NEW ADVENTURE                   |");
            Console.WriteLine("+----------------------------------------------------+"); 
            Console.WriteLine("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}! Your journey begins . . .\"");


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");


        }
   
    }
} 
