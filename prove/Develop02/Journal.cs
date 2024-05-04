using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal { //Stores a list of journal entries
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry userEntry){
        _entries.Add(userEntry);
    }
    public void DisplayAll(){
        foreach(Entry entry in _entries){   
            entry.Display();
        }
    }
    public void SaveToFile(string fileName){
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }
    public void LoadFromFile (string fileName){

                _entries.Clear();
                string[] lines = File.ReadAllLines(fileName);
 
                foreach (string line in lines)
                {
                    string[] parts = line.Split(" | ");
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];

                    Entry fileEntry = new Entry();
                    fileEntry._date = date;
                    fileEntry._promptText = prompt;
                    fileEntry._entryText = entryText;

                    AddEntry(fileEntry);
                }
    }

}