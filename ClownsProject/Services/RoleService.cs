using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClownsProject.Models;

namespace ClownsProject.Services
{
    public class RoleService
    {
        public static List<Role> GetRoles()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Roles.ToList();
            }
        }
    }
}
