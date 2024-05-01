using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Resume{
    public string name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayDetails(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs: ");

        foreach(Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}