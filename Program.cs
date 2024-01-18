// Author: Rachel Kircher
// Section: 002
using System;
using Mission_2;


class DiceSimulator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n\n");
        Console.Write("How many dice rolls would you like to simulate? "); // Enters number
        int numRolls = int.Parse(Console.ReadLine()); // Assigns number to variable

        DiceRoller roller = new DiceRoller(); //Instantiates a "Diceroller" object
        int[] results = roller.SimulateRolls(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS: \n");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.\n");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n"); 

        for (int iNum = 2; iNum <= 12; iNum++) //Percentage calc
        {
            int percentage = results[iNum] * 100 / numRolls;
            Console.WriteLine($"{iNum}: {new string('*', percentage)}"); //Graph
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

