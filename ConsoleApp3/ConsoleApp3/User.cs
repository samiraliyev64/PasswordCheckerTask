using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class User : IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;

        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public void PasswordChecker(string wifre)
        {
            int count1 = 0;
            int count2= 0;
            int count3 = 0;

            if (wifre.Length >= 8)
            {
                for (int i = 0; i < wifre.Length; i++)
                {
                    if (Char.IsUpper(wifre[i]))
                    {
                        count1++;
                    }

                    else if (Char.IsLower(wifre[i]))
                    {
                        count2++;
                    }

                    else if (Char.IsDigit(wifre[i]))
                    {
                        count3++;
                    }
                }

                if(count1 >= 1 && count2 >= 1 && count3 >= 1)
                {
                    Password = wifre;
                    Console.WriteLine($"Parolu duzgun daxil etdiniz, parolunuz : {Password}");
                }

                else
                {
                    Console.WriteLine("Qoydugunuz wifre muvafiq qaydalara uygun deyil");
                }
            }

            else
            {
                Console.WriteLine("Wifre en az 8 simvoldan ibaret olmalidir");
            }
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname : {Fullname}\nEmail : {Email}");
        }
    }
}
