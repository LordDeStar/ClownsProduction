using ClownsProject.Models;
using ClownsProject.Services;
using DevExpress.Mvvm.UI.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClownsProject.Controllers
{
    public class AdministratorController
    {
        public static void AddRole(string title)
        {
            using (var db = new MortalkombatContext())
            {
                if (db.Roles.Any(r => r.Title.Equals(title)))
                {
                    MessageBox.Show("Такая должность уже существует!");
                    return;
                }
                int id = RoleService.GetRoles().Last().IdRole + 1;
                Role role = new() { IdRole = id, Title = title };
                db.Roles.Add(role);
                db.SaveChanges();
                PageController.ShowAdminPage();
            }
        }
        public static void AddCompany(string brand, string pass)
        {
            using (var db = new MortalkombatContext())
            {
                if (db.Companies.Any(c => c.TradeMark.Equals(brand)))
                {
                    MessageBox.Show("Такая компания уже существует!");
                    return;
                }
                Company company = new() { TradeMark = brand, Password = pass };
                db.Companies.Add(company);
                db.SaveChanges();
                PageController.ShowAdminPage();
            }
        }
        public static void RegistrEmploy(string login, string password, string brand, string passForCompany, string role)
        {
            using (var db = new MortalkombatContext())
            {
                var idRole = db.Roles.FirstOrDefault(r => r.Title.Equals(role)).IdRole;
                var user = db.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Passwords.Equals(password));
                if (user is null)
                {
                    var isCorrectCompany = db.Companies.Any(c => c.TradeMark.Equals(brand) && c.Password.Equals(passForCompany));
                    if (isCorrectCompany)
                    {
                        user = new User
                        {
                            Login = login,
                            Passwords = password,
                            PhoneNumber = null,
                            IdRole = idRole,
                            Brand = brand,
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно!");
                        PageController.ShowAdminPage();
                    }
                    else
                    {
                        MessageBox.Show("Неверное название компании или пароль!");
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                }
            }
        }
    }
}
