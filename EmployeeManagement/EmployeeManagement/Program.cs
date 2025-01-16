using System;
using System.Drawing;

namespace EmployeeManagement
{
    class Program
    {
        private static void Main(string[] args)
        {
            Employee emp1 = new("john doe", 50000, new DateTime(2020, 1, 15));
            Employee emp2 = new("jane smith", 60000, new DateTime(2018, 5, 25));

            emp1.AddSkill("c#");
            emp1.AddSkill("sql");
            emp1.AddSkill("javascript");

            emp2.AddSkill("python");
            emp2.AddSkill("django");
            emp2.AddSkill("Machine learning");


            Console.WriteLine(emp1);
            Console.WriteLine($"{emp1.GetName()}'skills");
            emp1.DisplaySkills();

            Console.WriteLine(emp2);
            Console.WriteLine($"{emp2.GetName()}'skills");
            emp2.DisplaySkills();



            emp1.PayRaise(5000m);
            emp2.PayRaise(7000m);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            //display user profiles


        }
    }
}