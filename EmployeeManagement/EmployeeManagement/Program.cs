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

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            emp1.PayRaise(5000m);
            emp2.PayRaise(7000m);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

        }
    }
}