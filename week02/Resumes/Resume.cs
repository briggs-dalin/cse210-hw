using System;
//Making the Resume Class
public class Resume
{
    public string _name;
    //Making a new list to use for my resume class
    public List<Job> _jobs = new List<Job>();


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        //Will iterate through each element in the _jobs list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}