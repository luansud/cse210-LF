using System;
class Rectangle : Shape{
    protected double _width;
    protected double _height;

    public Rectangle(string color, double width, double height) : base(color){
        _width = width; 
        _height = height;
    }
    public override double GetArea(){
        return _height * _width;
    }
}