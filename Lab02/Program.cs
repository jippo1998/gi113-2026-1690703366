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
            // part a
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

            // part b
            string bossName = "joppo";
            int level = 14;

            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Boss Level: {level}");
            Console.WriteLine();

            string playerName = "jeymye";
            char Rank = 'c';

            Console.WriteLine($"Player Name: {playerName}");
            Console.WriteLine($"Player Rank: {Rank}");
            Console.WriteLine();

            string monsterName = "jippo";
            int maxHp = 500;
            int currentHp = 200;

            Console.Write($"Monster Name: {monsterName}")
            Console.WriteLine($"Monster HP: {currentHp} / {maxHp}");
            Console.WriteLine();

            string NPCName = "duppo";
            float attackPower = 43.5f;

            Console.WriteLine($"NPC Name: {NPCName}");
            Console.WriteLine($"NPC Attack Power: {attackPower}");
            Console.WriteLine();

            string petName = "gongkum";
            double petSpeed = 18.5;
            bool isPet = true;

            Console.WriteLine($"Pet Name: {petName}");
            Console.WriteLine($"Pet Speed: {petSpeed}");
            Console.WriteLine($"Is Pet: {isPet}");
            Console.WriteLine();
        }
    }
}
