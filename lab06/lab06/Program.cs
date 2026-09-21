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
            Console.WriteLine("continue to run");
        }
    }
}
