using System;

class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() :base("ListingActivity","..."){

    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        // Breathing();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt(){
        Random random= new Random();

    }
    public List<string> GetListFromUser(){
        return _prompts;
    }
}