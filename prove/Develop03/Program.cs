using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Jhon", 3,16);
        Scripture scripture1 = new Scripture(reference1, "Come unto me i will show you your weakness");
        Console.Clear();
        System.Console.WriteLine(scripture1.GetDisplayText());
        System.Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        bool finish = true;
        string userResponse;
        while (finish == true){
            userResponse = Console.ReadLine();
            Console.Clear();
            scripture1.HideRandomWords();
            System.Console.WriteLine(scripture1.GetDisplayText());
            System.Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            if (userResponse == "quit" || scripture1.IsCompletelyHidden() == false){
                finish = false;
            }
        }
    }
}