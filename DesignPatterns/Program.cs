using System;

namespace DesignPatterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Usage of Singleton and Facade

            // Creating the Singleton instance
            var userManager = UserManager.Instance;

            // Creating the Facade instance
            var userApiFacade = new UserApiFacade(userManager);

            // Using the Facade to create a user
            userApiFacade.CreateUser("John Doe", 25);

            // Using the Facade to get all users
            var users = userApiFacade.GetAllUsers();

            // Displaying the users
            Console.WriteLine("Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
            }
        }
    }
}