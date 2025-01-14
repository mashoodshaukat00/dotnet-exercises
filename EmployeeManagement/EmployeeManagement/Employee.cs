namespace EmployeeManagement
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private DateTime joinDate;

        public Employee(string name, decimal salary, DateTime joinDate)
        {
            this.name = name;
            this.salary = salary;
            this.joinDate = joinDate;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public decimal GetSalary ()
        {
            return salary;
        }

        public void SetSalary (decimal salary)
        {
            this.salary = salary;
        }

        public DateTime GetJoinDate() 
        { 
            return joinDate;        
        }

        public void SetJoinDate(DateTime joinDate)
        {
            this.joinDate = joinDate;
        }

        public void PayRaise(decimal amount)
        {
            salary += amount;
        }

        public override string ToString()
        {
            return $"Name: {name}, Salary: {salary}, join date: {joinDate}";
        }
    }
}
