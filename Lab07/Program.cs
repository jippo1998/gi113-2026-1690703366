/*
* Student ID :1690703366
* Name       :เมธปรียา บุญมาวงศ์
* Section    :129D
* No.        :N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("          >>> MOONLIGHT GIRL <<<");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine("=========== BATTLE MENU =============");
            Console.WriteLine("1) Pink Slash");
            Console.WriteLine("2) Star Magic");
            Console.WriteLine("3) Guard");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Moon Beam");
            Console.WriteLine("======================================");

            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("She swings her Pink Sword!");
                    break;

                case 2:
                    Console.WriteLine("She casts Star Magic!");
                    break;

                case 3:
                    Console.WriteLine("She raises her guard!");
                    break;

                case 4:
                    Console.WriteLine("She turns around and runs!");
                    break;

                case 5:
                    Console.WriteLine("She summons a powerful Moon Beam!");
                    break;

                default:
                    Console.WriteLine("She hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 15,
                _ => 0
            };

            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };

            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp
                ? "DEFEATED"
                : "still standing";

            Console.WriteLine($"Slime: {monsterStatus}");

            Console.WriteLine("--------------------------------------");
            Console.Write("Really run away? (y/n): ");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("She escaped safely!");
                    break;

                case "n":
                case "N":
                    Console.WriteLine("She stays and continues the fight.");
                    break;

                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
            Console.WriteLine("======================================");
            Console.WriteLine("        BATTLE SESSION COMPLETE");
            Console.WriteLine("======================================");
        }
    }
}
