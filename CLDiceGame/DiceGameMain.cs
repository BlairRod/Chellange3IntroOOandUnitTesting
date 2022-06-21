using System;

namespace CLDiceGame;

public class DiceGameMain
{
    static void Main(string[] args)
    {

        ClGame game = new ClGame();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Swinburne Caves and Lizards Club Dice game");
        Console.WriteLine("-------------------------------------------------");
        while (true)
        {
            Console.WriteLine("How many dice do you want to roll from 1 to 6?");
            var num = Convert.ToInt32(Console.ReadLine());
            // Checks num isn't over 6 and sets it to 6 if it is.
            if (num > 6)
            {
                num = 6;
                Console.WriteLine("Incorecct input, rolling 6 dice");
            }
            // Checks num isn't under or equal to 0 and sets it to 1 if it is.
            else if (num <= 0)
            {
                num = 1;
                Console.WriteLine("Incorec input, rolling 1 dice");
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Rolling " + num + " dice");
            for (int i = 0; i < num; i++) game.AddDie(6);
            game.RollAllDice();
            foreach (int i in game.results) Console.WriteLine(i);
            Console.WriteLine("Total of dice: " + game.GetTotal());
            Console.WriteLine("Average of dice: " + game.GetAverage());
            Console.WriteLine("-------------------------------------------------");
            if (Continue() == false) break;
        }

    }

    // Method to ask if user wants to play again.
    public static bool Continue()
    {
        Console.WriteLine("Roll again Y/N?");
        var cont = Console.ReadLine();
        if (cont.ToLower() == "n" || cont.ToLower() == "no")
        {
            Console.WriteLine("Thankyou for playing");
            Console.WriteLine("Goodbye");
            Console.WriteLine("-------------------------------------------------");
            return false;
        }
        else if (cont.ToLower() == "y" || cont.ToLower() == "yes")
        {
            Console.WriteLine("Playing again");
            Console.WriteLine("-------------------------------------------------");
            return true;
        }
        else
        {
            Console.WriteLine("Incorrect selection! Playing again...");
            Console.WriteLine("-------------------------------------------------");
            return true;
        }
    }
}