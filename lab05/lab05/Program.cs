

namespace lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-titleConsole.WriteLine("==>> Hunter Gate <<==");
            Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator");

            // Hero stats inputConsole.Write("Hero health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats inputConsole.Write("Monster health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

            // Input vaidation / outputbool heroStattValid = heroHpOk && heroAtkOk && heroDefOk;
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monStattValid = monHpOk || monAtkOk || monDefOk;
            Console.WriteLine($"\nHERO STAT: {heroStatValid}");
            Console.WriteLine($"MONSTER STAT: {monStattValid}");

            // bool AllStatOk = heroStatValid & Arithmetic ( + )

            // Compound Assinm & arithmetic ( + )
            int potionHeal = 5;

            heroHp = potionHeal;
            //heroHp = herohp + potionHeal;
            Console.WriteLine($"\nHero drink a potion, heals {potionHeal} Hp. Hero HP: {heroHp}");

            //Normol Attack RPG Stylr combat ATK > DEF ถึงจะมี Damage ต่อศัตรู
            int normaldmg = Math.Max( 0,heroAtk - monsterDef);

            //power attack

            //random critical attack
            Random rng = new Random();
            int critRoll = rng.Next(1, 101); // อยากสุ่มโอกาส 100%
            bool isCrit = critRoll <= 25; // 25% Chance of Critical

            int critDmg = normaldmg + Convert.ToInt32(isCrit) * normaldmg;
            Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player would deal {critDmg} DMG!!");
            Console.WriteLine();


        }
    }
}
