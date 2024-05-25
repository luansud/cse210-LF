using System;

class SimpleGoal : Goal{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name,description,points){

    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base (name,description,points){
        _isComplete = isComplete;
    }

    public override int RecordEvent(){
        // If we previously were not complete,
        // them mark complete and return points

        // what if we previously were complete?

        return 0;
    }

    public override bool IsComplete(){
        // return back whether this goal is complete or not

        return false;
    }


    public override string GetStringRepresentation(){
        return "Simple Goal:"+"|"+_shortName+"|"+_description+"|"+_points+"|"+_isComplete;
    }

}