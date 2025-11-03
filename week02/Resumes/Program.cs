using System;
using System.Runtime.Serialization.Json;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engeneer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";


        Job job2 = new Job();
        job2._jobTitle = "Data analist";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        Resume myResume = new Resume();
        myResume._newJob.Add(job1);
        myResume._newJob.Add(job2);

        myResume._name = "Allison Rose";
        myResume.DisplayResume();

    }
}