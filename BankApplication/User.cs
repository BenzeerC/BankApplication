using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string ContactNo { get; set; }
        public int RoleId { get; set; }
    }

    public class UserCRUD
    {
        private List<User> users;

        public UserCRUD()
        {
            users = new List<User>();
            users.Add(new User { UserId = 101, UserName = "admin", Password = "admin101", ContactNo = "2536495", RoleId = 1 });
        }

        public void AddUser(User user)// Add Users
        {
            users.Add(user); 
        }

        public int Login(int UserId,string Password)//Login 
        {
            int RoleId = 0;
            foreach (User user in users)
            {
                if (user.UserId == UserId && user.Password == Password)
                {
                    RoleId = user.RoleId;
                    break;

                }
            }
            return RoleId;
        }

        public List<User> GetUsers() 
        { 
        return users;   
        }

        public void Logout()
        {
            User user1 = new User();
            foreach (User user in users)
            {
                user.RoleId.ToString().Remove(user.RoleId);
                Console.WriteLine($"Enter your UserId for logout:{user1.UserId}");
                Console.WriteLine("Log out successfuly");
            }
        }

       
    }
}
