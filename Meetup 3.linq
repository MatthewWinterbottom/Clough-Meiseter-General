<Query Kind="Program" />

void Main()
{
    /*
        We need you to do the following:
        
        - Make a guessing game
        - Where you guess for the correct number
        - The correct number needs to be randomly generated from 1 - 100
        - The guesser can have 6 tries
        - If the guesser is wrong, we return whether the correct number is higher or lower
    */
    
    
    // 1. Randomly Generate a number between 1 and 100
    
    var randomNumber = new Random().Next(100);
    
    // 2. Get them to write something
    
    Console.WriteLine("Please write a number between 1 and 100");
    
    for (int i = 0; i < 6; i++)
    {
        string userInput = Console.ReadLine();
        
        int guess = 0;
        
        try
        {	        
           guess = int.Parse(userInput);       
        }
        catch
        {
            Console.WriteLine("Enter a valid number, please!");
            i--;
            continue;
        }
    
        
        if (guess == randomNumber)
        {
            Console.WriteLine("Your guess is correct");
            break;
        }
        else if  (guess > randomNumber)
        {
            Console.WriteLine("The correct number is lower than your guess, try again. Your Guess was {0}",guess);
        }
        else
        {
            Console.WriteLine("The correct number is higher than your guess, try again. Your Guess was {0}",guess);
        }
         
        if (i == 5)
        {
            Console.WriteLine(" GAME OVER, the answer was {0}", randomNumber);
        }
    }
}
