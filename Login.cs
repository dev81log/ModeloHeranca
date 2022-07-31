using System;

namespace Heranca
{
    public class Login : User
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void CheckingLogin(string UserEmail, string UserPassword)
        {
            if (Email == UserEmail && Password == UserPassword)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Login Failed!");
            }
        }

        public override string ToString()
        {
            return "Email: " + Email + " Password: " + Password;
        }


    }
}