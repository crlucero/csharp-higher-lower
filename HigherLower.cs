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
        Console.WriteLine("Would you like to play the higher/lower game? (Y/N)");
        string start = Console.ReadLine();
        
        if (start == "Y" || start == "y") 
        { 
            Console.WriteLine("Please pick a number between 1-100");
            min = 0;
            max = 101;
            ave = (min +  max)/2;
        } 
        else 
        {
            return;
        }

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