using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type your grade Percentage");
        string gradePercentage = Console.ReadLine();   
        int grade = int.Parse(gradePercentage);
        string letter = "";
        string sign = "";

        if (grade >= 90){
            letter = "A";
        } else if (grade >=80){
            letter = "B";
        } else if (grade >= 70){
            letter = "C";
        } else if (grade >= 60){
            letter = "D";
        } else if (grade < 60){
            letter = "F";
        } 

        //Stretch 1 Challenge
        int remainder = grade%10;
        if (remainder >= 7){
            sign = "+";
        } else if (remainder < 3){
            sign = "-";
        } 

        // Stretch 2 and 3 Challenge
        string final_grade = letter+sign;
        if (final_grade == "A+"){
            final_grade = "A";
        } else if (final_grade == "F+" || final_grade == "F-"){
            final_grade = "F";
        }

        Console.WriteLine($"Your grade was {final_grade}");
        if (grade >= 70){
            Console.WriteLine("Contratulations, You have been aproved");
        } else {
            Console.WriteLine("You didn't get it,but don't give up, keep trying and you'll do it");
        }
    }
}