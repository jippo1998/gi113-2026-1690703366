namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Rose Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 1000.0;

            Console.WriteLine("========================================");
            Console.WriteLine("       PRINCESS MAGIC FORGE");
            Console.WriteLine("========================================");
            Console.WriteLine("      Welcome, Little Blacksmith!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Material : {MaterialName}");
            Console.WriteLine($"Smelt    : {SmeltRate:F4}");
            Console.WriteLine($"Salvage  : {SalvageRate:F4}");
            Console.WriteLine($"Max Batch: {MaxBatch:F0}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("S = Smelt Ore into Ingot");
            Console.WriteLine("B = Breakdown Ingot into Ore");
            Console.WriteLine("========================================");

            Console.Write("Choose Menu: ");
            char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("How much would you like: ");
            bool amountParsed = double.TryParse(
                Console.ReadLine(),
                out double amount
            );

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            if (amountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;

                    Console.WriteLine("MAGIC SMELTING");
                    Console.WriteLine("The princess heats the forge...");
                    Console.WriteLine();
                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot"
                    );
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate;

                    Console.WriteLine("MAGIC BREAKDOWN");
                    Console.WriteLine("The princess carefully breaks the ingot...");
                    Console.WriteLine();
                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore"
                    );
                }
                else
                {
                    Console.WriteLine("Invalid menu!");
                    Console.WriteLine("Please choose S or B.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount!");
                Console.WriteLine($"Amount must be greater than 0 and at most {MaxBatch:F0}.");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("       FORGE SESSION COMPLETE");
            Console.WriteLine("     Thank you, Little Blacksmith!");
            Console.WriteLine("========================================");
        }
    }
}
