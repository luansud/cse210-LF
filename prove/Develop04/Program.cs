using System;

class Program
{
    static void Main(string[] args)
    {
        int s = 0;
        while (s != 4){
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start Listening activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            s = int.Parse(Console.ReadLine());
            Console.Clear();

            if (s == 1){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            } else if(s == 2){

            } else if(s == 3){
                
            } else if(s == 4){
                
            }


        }
    }
}