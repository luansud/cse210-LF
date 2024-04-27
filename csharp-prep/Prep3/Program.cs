using System;

class Program
{
    static void Main(string[] args)
    {
        // Stretch 2 challenge 1° Part
        string play = "y";
        while (play.ToLower() == "y" || play.ToLower() == "yes"){
            // Generating a random magic number
            Random randomNumber = new Random();
            int magic_number = randomNumber.Next(1,101);  

            // Asking the user for a guess
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine(); 
            int attempts = 1;
            // Looping for check the guess
            while (int.Parse(guess) != magic_number){
                if (int.Parse(guess) > magic_number) {
                    Console.WriteLine("Lower");
                } else if (int.Parse(guess) < magic_number) {
                    Console.WriteLine("Higher");
                }

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                // Stretch 1 Challenge
                attempts++;
            };

            Console.WriteLine($"You guessed it in {attempts} attempts");
            Console.WriteLine("--------------------------");
            //Stretch 2 Challenge 2º Part
            Console.WriteLine("Do you want to play again (y/n)");
            play = Console.ReadLine();
        }
        
        Console.WriteLine("Thank you for play with us");
    }
}