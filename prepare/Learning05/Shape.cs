using System;
using System.Drawing;
class Shape{
    protected string _color;

    public Shape(string color){
        _color = color;
    }
    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }

    public virtual double GetArea(){
        return 0;
    }

    public void DisplayColorArea(){
        Console.WriteLine($"Color: '{GetColor()}' \nArea: {GetArea()}");
    }
}