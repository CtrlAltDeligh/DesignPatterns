using System.Collections.Generic;
namespace DesignPatterns
{
    public class UserApiFacade
    {
        /* Facade Design Pattern-The Facade design pattern provides a unified interface
         to a set of interfaces in a subsystem.
         It defines a higher-level interface that makes the subsystem easier to use.*/
            private readonly UserManager _userManager;

            public UserApiFacade(UserManager userManager)
            {
                _userManager = userManager;
            }

            public void CreateUser(string name, int age)
            {
                // Additional logic if needed
                // ...

                // Using the UserManager to add a user
                var user = new User { Name = name, Age = age };
                _userManager.AddUser(user);

                // Additional logic if needed
                // ...
            }

            public List<User> GetAllUsers()
            {
                // Additional logic if needed
                // ...

                // Using the UserManager to get all users
                return _userManager.GetAllUsers();

                // Additional logic if needed
                // ...
            }
        }
    }
