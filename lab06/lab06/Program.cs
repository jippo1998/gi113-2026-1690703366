/*
Student ID : 1690703366
Name       : เมธปรียา บุญมาวงศ์
Section    : SAC D 
No.        : 2
*/
namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hero Stats
            int heroHp = 100;
            int heroMana = 50;
            int heroAtk = 30;
            int heroDef = 20;

            // Monster Stats
            int monHp = 120;
            int monAtk = 25;

            // Potion
            int potionCount = 3;
            int attackBuff = 20;

            bool parryActive = false;

            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|            LITTLE DRAGON             |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|              HERO STATUS             |");
            Console.WriteLine("|                                      |");
            Console.WriteLine($"|  HP      : {heroHp,-3} / 100               |");
            Console.WriteLine($"|  MANA    : {heroMana,-3} / 100               |");
            Console.WriteLine($"|  ATTACK  : {heroAtk,-3}                  |");
            Console.WriteLine($"|  DEFENSE : {heroDef,-3}                  |");
            Console.WriteLine($"|  POTION  : {potionCount,-3}                  |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|             MONSTER STATUS           |");
            Console.WriteLine("|                                      |");
            Console.WriteLine($"|  MONSTER HP     : {monHp,-3} / 120          |");
            Console.WriteLine($"|  MONSTER ATTACK : {monAtk,-3}               |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                ACTION                |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [1] ATTACK                         |");
            Console.WriteLine("|      Attack the monster              |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [2] PARRY                          |");
            Console.WriteLine("|      Reduce damage by 50%             |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [3] DRINK POTION BUFF              |");
            Console.WriteLine("|      Increase Attack by 20           |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            Console.Write("\n>>> CHOOSE YOUR ACTION (1-3): ");

            bool isInputValid = int.TryParse(
                Console.ReadLine(),
                out int choice
            );

            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Please enter action between 1 and 3.");
            }
            else if (choice == 1)
            {
                monHp -= heroAtk;

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("ACTION: ATTACK");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(
                    $"Little Dragon attacked with {heroAtk} DMG!"
                );

                if (monHp <= 0)
                {
                    Console.WriteLine("Monster is defeated!");
                }
                else
                {
                    Console.WriteLine(
                        $"Monster HP is now {monHp}."
                    );
                }
            }
            else if (choice == 2)
            {
                parryActive = true;

                int damageTaken = monAtk;

                if (parryActive == true)
                {
                    damageTaken = monAtk / 2;
                }

                heroHp -= damageTaken;

                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("ACTION: PARRY");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Little Dragon prepared to parry!");
                Console.WriteLine("Parry reduced damage by 50%.");
                Console.WriteLine($"Monster attacked for {monAtk} DMG.");
                Console.WriteLine($"Hero took {damageTaken} DMG.");
                Console.WriteLine($"Hero HP is now {heroHp}.");
            }
            else if (choice == 3)
            {
                if (potionCount > 0)
                {
                    potionCount--;
                    heroAtk += attackBuff;

                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("ACTION: DRINK POTION BUFF");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Little Dragon drank a potion!");
                    Console.WriteLine(
                        $"Attack increased by {attackBuff}."
                    );
                    Console.WriteLine(
                        $"Hero Attack is now {heroAtk}."
                    );
                    Console.WriteLine(
                        $"Potions remaining: {potionCount}"
                    );
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You have no potions left!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|             BATTLE END               |");
            Console.WriteLine("+--------------------------------------+");
        }

    }
}
