using System;
class Circle : Shape{
    protected double _radio;

    public Circle(string color, double radio) :base(color){
        _radio = radio;
    }
    public override double GetArea(){
        return 3.14 * (_radio * _radio);
    }
}