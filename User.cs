using System;


namespace Heranca
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }


        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetUsername(string username)
        {
            Username = username;
        }
        public string GetUsername()
        {
            return Username;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetIsAdmin(bool isAdmin)
        {
            IsAdmin = isAdmin;
        }
        public bool GetIsAdmin()
        {
            return IsAdmin;
        }

        public User() { }

        public User(int id, string username, string password, string email, bool isAdmin)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Password: ******, Email: {Email}, IsAdmin: {IsAdmin}";
        }

    }
}