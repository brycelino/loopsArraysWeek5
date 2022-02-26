using System;

namespace loopsWeek5
{
    class Program
    { 
        static void Main(string[] args)
        {
            ProblemOne();// calls method problem one
            ProblemTwo(); // calls method problem two 
            ProblemFour(); // calls method problem four
            Console.ReadKey(true);
        }
        public static void ProblemOne() // Declares method allows it to be the used in main
        {
            int count = 0; // Declares int count initialize with 0

            for(int i = 1; i <= 100; i++) // for loop that makes i iterate from 1 to 100
            {
                if (i % 3 == 0) // if i divided by 3 gives a remainder of 0 add 1 to count
                    count++; // increments count
            }
            Console.WriteLine("There are " + count + " total numbers that are divisble by 3 between 1 and 100.");// Displays how many numbers are divisble by 3
        }
        public static void ProblemTwo() // Declares method allows it to be the used in main
        {
            string Userinput; // Declares User input as a string 
            int sum = 0; // Declares sum as int to 0

            while(true) // repeats the loop until it is exited by break statement
            {
                Console.WriteLine("Enter a number or ok to exit."); // Ask the user to enter a number or ok to exit
                Userinput = Console.ReadLine(); // user input string gets the users answer
                if (Userinput.ToLower() == "ok") // if statement for if the users capitalizes OK they stil get "ok"
                    break; // break statement if user inputs ok then the progeram will exit
                sum += Convert.ToInt32(Userinput);  // converts userinput to int allows user numbers to be added
              
            }
            Console.WriteLine("The total of all your entered numbers is: " + sum); // Displays the total amount
        }

        public static void ProblemFour() // declares method allows it to be used in main
            
        {
            int userGuess; // declare user guess to int
            int randomNumber = new Random().Next(1, 10); // Declares random number as int and declares random number generator function
           // Console.WriteLine(randomNumber); the output for the number that the program randomly selects
            for (int i = 0; i < 4; i++)//  for loop to control the amount of trys the user gets 4 attempts
            { 
            Console.WriteLine("Guess the random number the AI selects. You get 4 attempts." );// asks the user to guess the number the program selects and the amount of trys given
            userGuess = Convert.ToInt32(Console.ReadLine()); // conberts the users input into an integer 
            if (userGuess == randomNumber) // checks to see if the user guessed the correct number
                {
                    Console.WriteLine("You Guessed Correct!"); // Displays if the user got it correct
                    return; 
                }
               
            }
            Console.WriteLine("You Lose!"); // displays you lose to the if the user didn't guess in 4 trys 
        }
     }
    
 }


