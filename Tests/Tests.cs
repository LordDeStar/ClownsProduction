using ClownsProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Test5_DeletingUserWithCorrectInput()
        {
            string login = "lorddestar";
            Assert.IsTrue(UserController.Delete(login));
        }

        [TestMethod]
        public void Test6_DeletingUserWithIncorrectInput()
        {
            string login = "lorddestar";
            Assert.IsFalse(UserController.Delete(login));
        }
    }
}