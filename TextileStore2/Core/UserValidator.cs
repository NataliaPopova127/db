using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileStore2.Models.Entities;

namespace TextileStore2.Core
{
    public class UserValidator
    {
        public static User User { get; set; }
        public static bool ValidateUser(string login, string password)
        {
            using(TradeEntities context = new TradeEntities())
            {
                var user = context.User.FirstOrDefault(u => u.UserLogin == login
                            && u.UserPassword == password);
                if (user != null)
                {
                    User = user;
                    return true;
                }
                else return false;
            }
            
        }
        public static int ValidateRole()
        {
            return User.UserRole;
        }
    }
}
