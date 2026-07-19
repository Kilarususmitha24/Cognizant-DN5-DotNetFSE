using System;

namespace UserManagerLib
{
    public class UserManager
    {
        public string AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("User name cannot be empty");

            if (user.Age < 18)
                throw new ArgumentException("User age should be at least 18");

            return "User Added Successfully";
        }
    }
}
