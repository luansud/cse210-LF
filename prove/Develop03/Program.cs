using System;

// ------ EXCEED REQUIREMENTS
// Select a random number of word between 2 and 4 to hide each time.
// Only hide words that are not hidden yet. 
// I put in an option for the user to type return and the scripture appears complete again.
// I've added a exception for avoid mistakes when converting the user's input to lower case. 


class Program
{
    static void Main(string[] args)
    {
        // Creating Instances
        Reference reference1 = new Reference("2 Nefi", 25,26);
        Scripture scripture1 = new Scripture(reference1, "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
        // Cleaning Console
        Console.Clear();
        System.Console.WriteLine("     Welcome to our Scripture Memorizer     ");
        System.Console.WriteLine("--------------------------------------------------------------");
        System.Console.WriteLine(scripture1.GetDisplayText());
        System.Console.WriteLine("--------------------------------------------------------------");
        System.Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        System.Console.WriteLine("If you want the scripture to comeback complete type 'RETURN'.");

        bool finish = true;
        string userResponse;
        while (finish == true){
            userResponse = Console.ReadLine();
            Console.Clear();
            scripture1.HideRandomWords();
            System.Console.WriteLine(scripture1.GetDisplayText());
            System.Console.WriteLine("Press ENTER to continue or type 'QUIT' to finish: ");
            System.Console.WriteLine("If you want the scripture to comeback complete type 'RETURN'.");
            userResponse = userResponse.ToLower();
            if (userResponse == "quit" || scripture1.IsCompletelyHidden() == false){
                finish = false;
            } else if (userResponse == "return"){
                Main(args);
            }
        }
    }
}