using System;

class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() :base("ListingActivity","..."){

    }

    public void Run(){

    }
    public void GetRandomPrompt(){

    }
    public List<string> GetListFromUser(){
        return _prompts;
    }
}