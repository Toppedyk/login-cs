using System;
using System.Collections.Generic;
using login.Models;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            User taylor = new User("Taylor", "Hercules43");
            User logan = new User("Logan", "LoganTest");
            users.Add(taylor.Name, taylor);
            users.Add(logan.Name, logan);


            Console.Clear();
            System.Console.WriteLine("Welcome, Please login to continue");
            System.Console.Write("Username: ");
            string username = Console.ReadLine();
            System.Console.Write("Password: ");
            string password = Console.ReadLine();

            if(users.ContainsKey(username) && users[username].ValidatePassword(password))
            {
                System.Console.WriteLine("Successfully logged in");
            }
            else
            {
                System.Console.WriteLine("Invalid Username or Password!");
            }
        }
    }
}
