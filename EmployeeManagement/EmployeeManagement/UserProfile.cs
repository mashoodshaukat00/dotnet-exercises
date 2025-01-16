namespace EmployeeManagement
{
    public struct UserProfile
    {
        public string UserName { get; private set; }
        private string password;
        public string Email { get; private set; }

        public UserProfile (string userName, string password, string email)
        {
            UserName = userName;
            this.password =  password;
            Email = email;
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if(password == currentPassword)
            {
                password = newPassword;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"UserName: {UserName}, Email: {Email}";
        }
    }
}
