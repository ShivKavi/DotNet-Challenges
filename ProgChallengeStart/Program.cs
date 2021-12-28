using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool proceed = true;
            int count, guess;

           
            while(proceed==true) {

                int theNumber = new Random().Next(20);
                count = 0;
                guess = 0;
                Console.Write("{0}",theNumber);
                while(guess!=theNumber)
                {
                    Console.WriteLine("Enter your guess, or -1 to give up.");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if(guess < theNumber)
                    {
                         Console.WriteLine("Your guess is less than the actual number!");
                    }
                    else if(guess> theNumber)
                    {
                        Console.WriteLine("Your guess is greater than the actual number!");
                        
                    }
                    else if(guess==-1)
                    {
                        Console.WriteLine("END!");
                        break;
                    }
                    count++;
                }
                Console.WriteLine("Correct guess!");
                break;

            } 
            
            
        }
    }
}
