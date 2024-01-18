using Mission2;
using System;
using System.Runtime.InteropServices;
using System.Xml;
// Zach Hansen
// Mission2 assignment
// Section 001
// Create program class
internal class Program
{
    static void Main(string[] args)
    {
        // create function to do random
        Random random = new Random();
        // set variables
        int NumOfRolls;
        
        //write to the console asking for how many rolls and getting their input
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        NumOfRolls = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each * represents 1% of the total number of rolls."); 
        System.Console.WriteLine("Total number of rolls = " + NumOfRolls + "\n");

        //pull from the RollDie class
        RollDice rolldice = new RollDice();
        //put those dice rolls into an array
        int[] result = rolldice.rollTheDice(NumOfRolls);

        // for loop to output the results of the rolls
        //for (int i = 0; i < result.Length; i++)
        //{
        //    System.Console.WriteLine($" {i + 2}: {result[i]}");
        //}
        //call the histogram function
        Histogram(result, NumOfRolls);

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
    //Function to write and display the hisogram
    static void Histogram(int[] result, int NumOfRolls)
    {
        //Write histogram labels
        Console.WriteLine("Total\tFrequency\tPercentage");
        Console.WriteLine("---------------------------------");

        //for loop to go through the results and output the histogram with each * = to 1%
        for (int i = 0; i < result.Length; i++)
        {
            double percentage = (double)result[i] / NumOfRolls * 100;
            int asterisks = (int)Math.Round(percentage);

            Console.Write($"{i + 2}\t{result[i]}\t\t");

            for (int j = 0; j < asterisks; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine($" ({percentage:F2}%)");
        }
    }
}