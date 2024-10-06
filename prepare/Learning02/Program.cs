using System;

class Program
{
    static void Main(string[] args)
    {

        Resume name1 = new Resume();
        name1._name = "Hugo Reyes";



        Job job1 = new Job();
        job1._company = "[24]7.ai";
        job1._jobTitle = "Customer Service Representative";
        job1._startYear = 2017;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Conduent";
        job2._jobTitle = "Data Indexer";
        job2._startYear = 2020;
        job2._endYear = 2021;

        name1._jobs.Add(job1);
        name1._jobs.Add(job2);

        name1.DisplayResume();

    }
}