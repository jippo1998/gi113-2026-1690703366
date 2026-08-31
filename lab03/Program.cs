namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Maxlevel = 10;


            var bossName = "Kirin";

            var rank = 'S';

            int level = 7;

            int maxHp = 500;

            int currentHp = 250;

            float attackpower = 50.25f;

            double critMultiplier = 1.75;

            bool isBoss = true;

            //boss stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}");
            Console.WriteLine($"RANK: {rank}");
            Console.WriteLine($"LEVEL: {level} / {Maxlevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"ATTACK POWER: {attackpower}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier}");
            Console.WriteLine($"BOSS: {isBoss}");

            // Implicit Conversion: HP (INT) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (DOUBLE): {currentHpDouble}");

            // calcuate percent as double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {hpPercentExact}%");

            // Explicit casting attack power (foat) -->> int

            // Cast vs. Convert: Crit Multiplier 

        }
