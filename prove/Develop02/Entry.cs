using System;

class Entry{ // Represents a single journal entry.
    
    // Hold Data
    
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";


    public void Display(){
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    } 
}