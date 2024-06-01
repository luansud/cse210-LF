using System;

public class Comment{
    public string _name;
    public string _text;

    public Comment(string name, string text){
        _name = name;
        _text = text;
    }
    public void DisplayComments(){
        Console.WriteLine($"> {_name}: {_text}");
    }

}