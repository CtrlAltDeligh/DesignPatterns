using System.Collections.Generic;

namespace DesignPatterns
{
    public class UserManager
    {
       
        /*Singleton design pattern -The Singleton design pattern ensures that
        a class has only one
        instance and provides a global point of access to that instance*/
            private static UserManager _instance;
            private readonly List<User> _users;

            private UserManager()
            {
                _users = new List<User>();
            }

           
            public static UserManager Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new UserManager();
                    }
                    return _instance;
                }
            }

            public void AddUser(User user)
            {
                _users.Add(user);
            }

            public List<User> GetAllUsers()
            {
                return _users;
            }
        }
    }
