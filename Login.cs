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

        public void ChekingLogin()
        {
            if (Email == GetEmail() && Password == GetPassword())
            {
                Console.WriteLine("Login realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Login inválido!");
            }
        }

        public override string ToString()
        {
            return "Email: " + Email + " Password: " + Password;
        }


    }
}