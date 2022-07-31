namespace Heranca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.Clear();
            User user = new User(1, "Dev81log", "8833abcd", "dev81log@gmail.com", true);
            Login login = new Login("dev81log@gmail.com", "8833abcd");
            login.CheckingLogin(user.Email, user.Password);

        }
    }
}

