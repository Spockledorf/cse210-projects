using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Name", "Description", 30);

        myActivity.ShowSpinner(10);
        myActivity.ShowProgressBar(10);
    }
}