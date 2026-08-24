/*
 * Student ID :1690703366
 * Name       :เมธปรียา บุญมาวงศ์
 * Section    :129D
 * No.        :N/A
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

            Console.WriteLine("BOSS STATUS: INITIAL");
            Console.WriteLine($"NAME: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}"); 
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"crit Muliplier: {critMultiplier}");
            Console.WriteLine($"IS Boss: {isBoss}");
            Console.WriteLine();

            int hppercent = currentHp * 10 / maxHp;
            Console.WriteLine($"Boss HP: {hppercent}%");
            Console.WriteLine();

            Console.WriteLine($"kirin take 60 damage");
            currentHp -= 60;
            Console.WriteLine();

            Console.WriteLine("BOSS STATUS: AFTER DAMAGE");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hppercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Boss HP: {hppercent}%");

        }
    }
}
