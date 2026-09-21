


namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;//ตัวแปรหลักเพื่อเช็ก

            if (lives == 0) //ในวงเล็บคือเงื่อนไขที่ต้องเป็นจริง

            {
                //บล็อกของโค๊ดที่ทำงาน เมื่อเงื่อนไขเป้นจริง
                Console.WriteLine("Game Over");
            }
            else
            {
                //บล็อกของโค๊ดที่ทำงาน เมื่อเงื่อนไขเป้นเท็จ
                Console.WriteLine("Continue to play");
            }

            //เมื่อเงื่อนไขทำงานเสร็จแล้วเงื่อนไข เงื่อนไขไม่ตรงเลย โค๊ดทำงานต่อ
            Console.WriteLine("your livel (1-99) :");

            bool isPoisoned = false;
            if (isPoisoned) { } // ได้เลยเพราะ ispoisoned เป็น false
            if (isPoisoned) { } // ไม่ได้เพราะ ispoisoned 

            bool HASKEY = true;
            Console.WriteLine("your livel (1-99) :");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level input.");
            }
            else if (level <= 10 && HASKEY)
            {
                Console.WriteLine("Boss Floor unlocked!");
            }
            else if (level <= 5)
            {
                if (HASKEY == true)
                {
                    Console.WriteLine("the door is open.");
                }
                else
                {
                    Console.WriteLine("Interlocked find a key to open the door.");
                }
            }
            else
            {
                Console.WriteLine("the door stays shut");
            }
            //end

            /*
            Student ID : 1690703366
            Name       : เมธปรียา บุญมาวงศ์
            Section    : SAC D 
            No.        : 2
            */

            static void Main()
            {
                int heroHp = 100;
                int monsterHp = 100;

                Console.WriteLine("================================");
                Console.WriteLine("         HERO VS MONSTER");
                Console.WriteLine("================================");
                Console.WriteLine("Hero HP    : 100");
                Console.WriteLine("Monster HP : 100");
                Console.WriteLine();

                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Run Away");
                Console.WriteLine("3. Use Potion");
                Console.WriteLine();

                Console.Write("Your choice: ");

                int choice;
                bool ok = int.TryParse(Console.ReadLine(), out choice);

                // Check invalid input
                if (!ok)
                {
                    Console.WriteLine("Invalid input.");
                }
                else if (choice == 1)
                {
                    // Attack
                    monsterHp = monsterHp - 30;
                    heroHp = heroHp - 20;

                    Console.WriteLine();
                    Console.WriteLine("You attack the monster!");
                    Console.WriteLine("Monster takes 30 damage.");
                    Console.WriteLine("Monster HP is now " + monsterHp + ".");
                    Console.WriteLine("The monster attacks you for 20 damage.");
                    Console.WriteLine("Hero HP is now " + heroHp + ".");

                    if (heroHp >= 50)
                    {
                        Console.WriteLine("You are still strong!");
                    }
                    else if (heroHp > 0)
                    {
                        Console.WriteLine("Your HP is low!");
                    }
                    else
                    {
                        Console.WriteLine("Game Over!");
                    }
                }
                else if (choice == 2)
                {
                    // Run Away
                    heroHp = heroHp - 30;

                    Console.WriteLine();
                    Console.WriteLine("You try to run away!");
                    Console.WriteLine("The monster attacks you for 30 damage.");
                    Console.WriteLine("Hero HP is now " + heroHp + ".");
                    Console.WriteLine("You escaped from the monster!");

                    if (heroHp >= 50)
                    {
                        Console.WriteLine("You escaped safely!");
                    }
                    else
                    {
                        Console.WriteLine("You escaped, but you are badly injured.");
                    }
                }
                else if (choice == 3)
                {
                    // Use Potion
                    heroHp = heroHp + 20;

                    if (heroHp > 100)
                    {
                        heroHp = 100;
                    }

                    Console.WriteLine();
                    Console.WriteLine("You use a potion!");
                    Console.WriteLine("Hero recovers 20 HP.");
                    Console.WriteLine("Hero HP is now " + heroHp + ".");

                    if (heroHp >= 50)
                    {
                        Console.WriteLine("You feel stronger!");
                    }
                    else
                    {
                        Console.WriteLine("You still need to be careful.");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Please choose 1, 2, or 3.");
                }

                Console.WriteLine();
                Console.WriteLine("================================");
                Console.WriteLine("           GAME END");
                Console.WriteLine("================================");

               

            
            }
        }


    }
}
