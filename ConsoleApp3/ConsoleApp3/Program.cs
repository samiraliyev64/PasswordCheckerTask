using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("samir_aliyev_2001@inbox.ru", "Samir064aliyev");
            user1.Fullname = "Samir Aliyev";
            user1.ShowInfo();
            user1.PasswordChecker(user1.Password);
        }
    }
}
