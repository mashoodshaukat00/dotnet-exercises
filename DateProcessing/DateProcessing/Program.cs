using System;
using System.Reflection.Metadata.Ecma335;
namespace DataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueInput;
            string validDatesRecord = "";

            do
            {
                Console.Write("Please enter the date");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the month");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter the year");
                int year = int.Parse(Console.ReadLine());

                string result = ValidateDate(day, month, year);

                if(result.StartsWith("valid date"))
                {
                    validDatesRecord += $"{result}\n";
                }

                Console.WriteLine(result);

                Console.WriteLine($"Is {year} a leap year:  {IsLeapYear(year)}");

                Console.WriteLine("Do you want to enter another date? (yes/no)");
                continueInput = Console.ReadLine();

            }
            while (continueInput.Equals("yes", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nValid Dates Entered: ");
            Console.WriteLine(validDatesRecord);
            Console.WriteLine("Thank you for using date validator!");

               
            static string ValidateDate (int day, int month, int year)
            {
                if (year < 0 || year > 2099)
                {
                    return "invalid date";
                }
                if (month < 1 || month > 12)
                {
                    return "invalid date";
                }
                if(day < 0)
                {
                    return "invalid date";
                }

                int maxDay;

                switch(month)
                {
                    case 2: maxDay = IsLeapYear(year) ? 29 : 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        maxDay = 30;
                        break;
                    default:
                        maxDay = 31;
                        break;
                }

                if(day > maxDay)
                {
                    return "invalid date";
                }

                string monthName = GetMonthName(month);
                string daySuffix = GetDaySuffix(day);

                return $"Valid date: {day}{daySuffix} {monthName} {year}";
            }
            
        }
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static string GetMonthName (int month)
        {
            switch(month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: throw new ArgumentOutOfRangeException("Invalid month");
            }
        }

        static string GetDaySuffix(int day)
        {
            switch (day)
            {
                case 1: case 21: case 31: return "st";
                case 2: case 22: return "nd";
                case 3: case 23:  return "rd";
                default: return "th";
            }
        }
    }
}