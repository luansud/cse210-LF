using System;

abstract class Activity{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes){
        _date = date;
        _minutes = minutes;
    }

    public virtual void GetActivitySummary(string sport){
        Console.WriteLine($"{_date} {sport} ({_minutes} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace:{GetPace()} min per km");
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}