using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClownsProject.Models;

namespace ClownsProject.Services
{
    public class UserService
    {
        public static List<User> GetUsers()
        {
            using (MortalkombatContext db = new MortalkombatContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
