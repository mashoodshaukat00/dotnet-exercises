namespace EmployeeManagement
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private DateTime joinDate;

        private string[] skills;
        private int skillCount;
        private const int MaxSkills = 10;
       
        private UserProfile userProfile;

        public Employee(string name, decimal salary, DateTime joinDate)
        {
            this.name = name;
            this.salary = salary;
            this.joinDate = joinDate;

            this.skills = new string[MaxSkills];
            this.skillCount = 0;

            string userName = name.Replace(" ", " ");
            this.userProfile = new UserProfile(userName, "password", "email@domainName.com");
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

        public void AddSkill(string skill)
        {
            if(skillCount < MaxSkills)
            {
                skills[skillCount] = skill;
                skillCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more skills. Maximum limit reached.");
            }
        }

        public void DisplaySkills()
        {
            Console.WriteLine("Skills:");
            for(int i = 0; i < skillCount; i++)
            {
                Console.WriteLine($"-{skills[i]}");
            }
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            return userProfile.ChangePassword(currentPassword, newPassword);
        }

        public void DisplayUserProfile()
        {
            Console.WriteLine(userProfile);
        }

        public override string ToString()
        {
            return $"Name: {name}, Salary: {salary}, join date: {joinDate}";
        }
    }
}
