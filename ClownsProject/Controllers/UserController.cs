using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using ClownsProject.Models;
using ClownsProject.Services;

namespace ClownsProject.Controllers
{
    public class UserController
    {
        public static User CurrentUser { get; set; }

        public static bool Delete(string login)
        {
            using (var db = new MortalkombatContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Login == login);
                if (user == null)
                    return false;
                var tasks = TaskService.GetTasks().Where(t => t.Login == login && t.IdStatus != 3).ToList();
                if (tasks.Count != 0)
                {
                    MessageBox.Show("Пока у сотрудника есть незавершённые задачи его нельзя уволить!");
                    return false;
                }
                tasks = TaskService.GetTasks().Where(t => t.Login == login && t.IdStatus == 3).ToList();
                db.Tasks.RemoveRange(tasks);
                db.Users.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Увольнение произошло успешно!");
                return true;
            }
        }
        public static bool Authorization(string login, string pass)
        {
            using (var db = new MortalkombatContext())
            {
                db.Roles.ToList();
                CurrentUser = db.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Passwords.Equals(pass));
                if (CurrentUser != null)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    try
                    {
                        if (CurrentUser.IdRoleNavigation.Title.Equals("администратор"))
                        {
                            PageController.ShowAdminPage();
                        }
                        else if (CurrentUser.IdRoleNavigation.Title.Equals("менеджер"))
                        {
                            PageController.ShowProjectsPage();
                        }
                        else
                        {
                            var tasks = TaskService.GetTasks();

                            PageController.ShowTasksPage(tasks);
                        }
                    } catch(Exception ex) { }
                    return true;
                    
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                    return false;
                }
            }
        }
        public static bool Registration(string login, string password, string phoneNumber)
        {
            var phoneRegex_1 = new Regex(@"\+7\([0-9][0-9][0-9]\)[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]");
            var phoneRegex_2 = new Regex(@"8\([0-9][0-9][0-9]\)[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]");
            var phoneRegex_3 = new Regex(@"\+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            var phoneRegex_4 = new Regex(@"8[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");

            if (phoneRegex_1.IsMatch(phoneNumber) || phoneRegex_2.IsMatch(phoneNumber) || phoneRegex_3.IsMatch(phoneNumber) || phoneRegex_4.IsMatch(phoneNumber))
            {
                using (var db = new MortalkombatContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Passwords.Equals(password));
                    if (user is null)
                    {
                        user = new User
                        {
                            Login = login,
                            Passwords = password,
                            PhoneNumber = phoneNumber,
                            IdRole = 1,
                            Brand = "test",
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно!");
                        try
                        {
                            PageController.ShowAdminPage();
                        }
                        catch (Exception ex) { }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует!");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверый формат номера телефона!\nНомер должен соответсвовать одному из четырёх форматов:\n+7(XXX)XXX-XX-XX\n8(XXX)XXX-XX-XX\n+7XXXXXXXXXX\n8XXXXXXXXXX");
                return false;
            }
        }
        

    }
}
