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
                outputFile.WriteLine($"\nDate: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}");
            }
        }
    }
    public void LoadFromFile (string fileName){

    }

}