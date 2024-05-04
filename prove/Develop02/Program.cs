using System;

class Program
{
    static void Main(string[] args)
    {

        Journal _journal = new Journal();
        PromptGenerator _generator = new PromptGenerator();
        
        int userResponse = 0;
        while (userResponse != 5){

            PromptGenerator.PrintMenu();
            userResponse = int.Parse(Console.ReadLine());

            if (userResponse == 1)
            {
                Entry UserEntry = new Entry();
                UserEntry._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(UserEntry._promptText);
                UserEntry._entryText = Console.ReadLine();
                DateTime datenow = DateTime.Now;
                UserEntry._date = datenow.ToShortDateString();
                _journal.AddEntry(UserEntry);


            } else if (userResponse == 2)
            {
                _journal.DisplayAll();      
            } 
            else if (userResponse == 3)
            {

            } 
            else if (userResponse == 4)
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                _journal.SaveToFile(fileName);

            } 
            else {
                if (userResponse == 5){} 
                else {Console.WriteLine("Please type a correct option");}
            }

        }
        

    }
}