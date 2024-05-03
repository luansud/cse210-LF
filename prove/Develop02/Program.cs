using System;

class Program
{
    static void Main(string[] args)
    {

        Entry _entry = new Entry();
        Journal _journal = new Journal();
        PromptGenerator _generator = new PromptGenerator();
        
        int userResponse = 0;
        while (userResponse != 5){
            
            PromptGenerator.PrintMenu();
            userResponse = int.Parse(Console.ReadLine());

            if (userResponse == 1)
            {
                _entry._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(_entry._promptText);
                _entry._entryText = Console.ReadLine();
                DateTime datenow = DateTime.Now;
                _entry._date = datenow.ToShortDateString();
            } else if (userResponse == 2)
            {
                _entry.Display();
            }

        }
        

    }
}