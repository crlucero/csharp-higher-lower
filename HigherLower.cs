using System;
using System.Collections.Generic;

class HigherLower 
{


    public static void Main()
    {   
     int min;
     int max;
     int ave;
     bool correct = false;
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("----------------The Higher Lower Game--------------");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("Would you like to play the higher/lower game? (Y/N)");
        string start = Console.ReadLine();
        
        if (start == "Y" || start == "y")
        { 
            Console.WriteLine("Please enter 1 or 2 to choose a game mode.");
            Console.WriteLine(" 1 - User Picks number... 2 -The Computer will Pick a number  (1/2)");
            string mode = Console.ReadLine();

        // User picks number
            if(mode == "1"){

            Console.WriteLine("Please pick a number between 1-100");
            min = 0;
            max = 101;
            ave = (min +  max)/2;

                while (correct == false)
            {

                Console.WriteLine("Is your number higher or lower than " + ave + "? Higher/Lower/Correct");
                string answer = Console.ReadLine();
                if (answer == "Higher" || answer == "higher")
                {
                    min = ave;
                }
                else if (answer == "Lower" || answer == "lower")
                {
                    max = ave;
                }
                else if (answer == "Correct" || answer == "correct")
                {
                    Console.WriteLine("Great! I guessed your number. Would you like to play again? (Y/N)");
                    correct = true;
                }
                ave = (min +  max)/2;
            }
        } 
            // Computer picks random number
            else if(mode == "2")
        {
            Console.WriteLine("Computer Mode");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            Console.WriteLine("Try to Guess the number. It is between 1 and 100");
            string userGuess = Console.ReadLine();
            int guessInt = int.Parse(userGuess);

            while(correct == false)
            {
                if(randomNumber == guessInt)
                {
                    Console.WriteLine("Great! You guessed the number!");
                    correct = true;
                }
                else if(randomNumber > guessInt)
                {
                    Console.WriteLine("You guessed " + guessInt + ".The number is higher than your guess. Guess Again.");
                    userGuess = Console.ReadLine();

                }
                else if(randomNumber < guessInt)
                {
                    Console.WriteLine("You guessed " + guessInt + ".The number is lower than your guess. Guess Again.");
                    userGuess = Console.ReadLine();
                }
                guessInt = int.Parse(userGuess);
            }

        }

        
        // Continue option
        if(correct == true)
        {
            Console.WriteLine("Would you like to continue playing? (Y/N)");
            string continueGame = Console.ReadLine();
            if(continueGame == "Y" || continueGame == "y")
            {
            Main();
            }
            else
            {
             return;
            }
        }
    }
}
}