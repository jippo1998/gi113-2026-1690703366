


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

        }
    }
}
