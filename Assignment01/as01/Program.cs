/*
* Student ID :1690703366
* Name       :เมธปรียา บุญมาวงศ์
* Section    :129D
* No.        :N/A
* Course     : GI113 Computer Programming (GI)
*/namespace assingment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Little Misfortune - stat cardconst string GameTitle = "Little Misfortune"; 

            const string GameTitle = "Little mis fortune"; // const, PascalCase

            var characterName = "Misfortune";
            var characterRank = 'S';
            int age = 8;
            float happiness = 0.75f;
            double luck = 87.5;
            bool isPlayable = true;

            Console.WriteLine("██╗     ██╗████████╗████████╗██╗     ███████╗");
            Console.WriteLine("██║     ██║╚══██╔══╝╚══██╔══╝██║     ██╔════╝");
            Console.WriteLine("██║     ██║   ██║      ██║   ██║     █████╗  ");
            Console.WriteLine("██║     ██║   ██║      ██║   ██║     ██╔══╝  ");
            Console.WriteLine("███████╗██║   ██║      ██║   ███████╗███████╗");
            Console.WriteLine("╚══════╝╚═╝   ╚═╝      ╚═╝   ╚══════╝╚══════╝");
            Console.WriteLine("███╗   ███╗██╗███████╗");
            Console.WriteLine("████╗ ████║██║██╔════╝");
            Console.WriteLine("██╔████╔██║██║███████╗");
            Console.WriteLine("██║╚██╔╝██║██║╚════██║");
            Console.WriteLine("██║ ╚═╝ ██║██║███████║");
            Console.WriteLine("╚═╝     ╚═╝╚═╝╚══════╝");
            Console.WriteLine("███████╗ ██████╗ ██████╗ ████████╗██╗   ██╗███╗   ██╗███████╗");
            Console.WriteLine("██╔════╝██╔═══██╗██╔══██╗╚══██╔══╝██║   ██║████╗  ██║██╔════╝");
            Console.WriteLine("█████╗  ██║   ██║██████╔╝   ██║   ██║   ██║██╔██╗ ██║█████╗  ");
            Console.WriteLine("██╔══╝  ██║   ██║██╔══██╗   ██║   ██║   ██║██║╚██╗██║██╔══╝  ");
            Console.WriteLine("██║     ╚██████╔╝██║  ██║   ██║   ╚██████╔╝██║ ╚████║███████╗");
            Console.WriteLine("╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═══╝╚══════╝");

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║          ✦ CHARACTER PROFILE ✦           ║");
            Console.WriteLine("╠══════════════════════════════════════════╣");
            Console.WriteLine($"║  ♡ Character : {characterName,-24}  ║");
            Console.WriteLine($"║  ★ Rank      : {characterRank,-24}  ║");
            Console.WriteLine($"║  ☺ Age       : {age,-24}  ║");
            Console.WriteLine("╠══════════════════════════════════════════╣");
            Console.WriteLine("║              CHARACTER STATS             ║");
            Console.WriteLine("╠══════════════════════════════════════════╣");
            Console.WriteLine($"║  ♡ Happiness : {happiness,-24}  ║");
            Console.WriteLine($"║  ★ Luck      : {luck,-24}  ║");
            Console.WriteLine($"║  ✓ Playable  : {isPlayable,-24}  ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.WriteLine();


            // Implicit conversion
            double ageAsDouble = age;
            Console.WriteLine($"Age as double (implicit): {ageAsDouble}");
            Console.WriteLine();
            // Explicit Cast
            int luckTruncated = (int)luck;
            // Convert.ToInt32
            int luckRounded = Convert.ToInt32(luck);
            Console.WriteLine($"Luck cast (Truncated) : {luckTruncated}");
            Console.WriteLine($"Luck convert (Rounded) : {luckRounded}");
            Console.WriteLine();




        }
    }
}