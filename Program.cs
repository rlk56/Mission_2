using System;

class DiceSimulator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n\n");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.SimulateRolls(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS: \n");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.\n");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        for (int iNum = 2; iNum <= 12; iNum++)
        {
            int percentage = results[iNum] * 100 / numRolls;
            Console.WriteLine($"{iNum}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    private Random random;

    public DiceRoller()
    {
        random = new Random();
    }

    public int[] SimulateRolls(int numRolls)
    {
        int[] results = new int[13];

        for (int iNum = 0; iNum < numRolls; iNum++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
