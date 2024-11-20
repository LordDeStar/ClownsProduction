using ClownsProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1_SignUpWithCorrectInput()
        {
            string phone = "89874917728";
            string login = "lorddestar";
            string pass = "1234";
            Assert.IsTrue(UserController.Registration(login, pass, phone));
        }

        [TestMethod]
        public void Test2_SignUpWithIncorrectInput()
        {
            string phone = "";
            string login = "";
            string pass = "";
            Assert.IsFalse(UserController.Registration(login, pass, phone));
        }

        [TestMethod]
        public void Test3_SignInWithCorrectInput()
        {
            string login = "lorddestar";
            string pass = "1234";
            Assert.IsTrue(UserController.Authorization(login, pass));
        }

        [TestMethod]
        public void Test4_SignInWithIncorrectInput()
        {
            string login = "";
            string pass = "";
            Assert.IsFalse(UserController.Authorization(login, pass));
        }
        [TestMethod]
        public void Test5_DeleteUserWithTask()
        {
            DateOnly start = DateOnly.FromDateTime(DateTime.Now);
            DateOnly end = DateOnly.FromDateTime(DateTime.Now);
            string login = "lorddestar";
            TaskController.AddTask("test", "test", login, start, end, "тест", "test");
            Assert.IsFalse(UserController.Delete(login));
        }
        [TestMethod]
        public void Test6_DeletingUserWithCorrectInput()
        {
            TaskController.ChangeStatus("выполнена", 1);
            string login = "lorddestar";
            Assert.IsTrue(UserController.Delete(login));
        }

        [TestMethod]
        public void Test7_DeletingUserWithIncorrectInput()
        {
            string login = "lorddestar";
            Assert.IsFalse(UserController.Delete(login));
        }
        
    }
}