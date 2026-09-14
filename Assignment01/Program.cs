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

            var characterName = "Misfortune";
            var characterRank = 'S';

            int age = 8;
            float happiness = 0.75f;
            double luck = 87.5;
            bool isPlayable = true;

            Console.WriteLine(" +-----------------------------------+");
            Console.WriteLine(" |                                   |");
            Console.WriteLine($" |       {GameTitle,-28}            |");
            Console.WriteLine(" |              STAT CARD            |");
            Console.WriteLine(" |                                   |");
            Console.WriteLine(" +-----------------------------------+");
            Console.WriteLine(" |                                    |");
            Console.WriteLine($" |  Character : {characterName,-22}|");
            Console.WriteLine($" |  Rank      : {characterRank,-22}|");
            Console.WriteLine($" |  Age       : {age,-22}|");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" |          CHARACTER STATS           |");
            Console.WriteLine(" |                                    |");
            Console.WriteLine($" |  Happiness : {happiness,-22}|");
            Console.WriteLine($" |  Luck      : {luck,-22}|");
            Console.WriteLine($" |  Playable  : {isPlayable,-22}|");
            Console.WriteLine(" |                                    |");
            Console.WriteLine(" +-------------------------------------+");
            Console.WriteLine();

            //implicit conversiondouble ageAsDouble = age;
            Console.WriteLine($"Age as double (implicit): {ageAsDouble}");
            Console.WriteLine();

            //Explicit Castint luckTruncated = (int)luck;
            Console.WriteLine();

            //Convert.ToInt32int luckRounded = Convert.ToInt32(luck);
            Console.WriteLine();

            Console.WriteLine($"Luck cast (Truncated) : {luckTruncated}");
            Console.WriteLine($"Luck convert (Rounded) : {luckRounded}");
            Console.WriteLine();




        }
    }
}
