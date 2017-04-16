namespace App.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        protected User()
        {
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }        
    }
}