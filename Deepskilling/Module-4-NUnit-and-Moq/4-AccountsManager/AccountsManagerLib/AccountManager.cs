using System;

namespace AccountsManagerLib
{
    public class AccountManager
    {
        public string Login(string userId, string password)
        {
            if (string.IsNullOrWhiteSpace(userId) ||
                string.IsNullOrWhiteSpace(password))
                throw new ArgumentException();

            if (userId == "user_1" && password == "secret@user11")
                return "Welcome user_1!!!";

            if (userId == "user_2" && password == "secret@user22")
                return "Welcome user_2!!!";

            return "Invalid user id/password";
        }
    }
}
