using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DangKy_52_Phu_57_Qui
{
    [TestClass]
    public class TestDangKy_52_Phu_57_Qui
    {
        IWebDriver driver_52_Phu_57_Qui;

        [TestInitialize]
        public void Initialize()
        {
            driver_52_Phu_57_Qui = new ChromeDriver();
        }

        public void SetUp()
        {
            driver_52_Phu_57_Qui.Navigate().GoToUrl("https://www.alphabooks.vn/");
            
        }
        [TestMethod]
        public void Test1_DangKyThanhCong()
        {
            SetUp();
            Thread.Sleep(1000);
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            driver_52_Phu_57_Qui.FindElement(By.LinkText("Đăng ký")).Click();
            Thread.Sleep(1000);
            driver_52_Phu_57_Qui.FindElement(By.Id("lastName")).SendKeys("Phan");
            driver_52_Phu_57_Qui.FindElement(By.Id("firstName")).SendKeys("Phu");
            driver_52_Phu_57_Qui.FindElement(By.Id("PhoneNumber")).SendKeys("0345678910");
            driver_52_Phu_57_Qui.FindElement(By.Id("email")).SendKeys("2151050334@ou.edu.vn");
            driver_52_Phu_57_Qui.FindElement(By.Id("password")).SendKeys("12345678");
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click();

            Thread.Sleep(10000);
            driver_52_Phu_57_Qui.Quit();
        }
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                         @".\RegisterData_52_Phu_57_Qui\TestRegisterData_52_Phu_57_Qui.csv", "TestRegisterData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]
        public void Test_DangKyThatBai()
        {
            SetUp();
            string lastName = TestContext.DataRow[0].ToString();
            string firstName = TestContext.DataRow[1].ToString();
            string phoneNumber = TestContext.DataRow[2].ToString();
            string email = TestContext.DataRow[3].ToString();
            string password = TestContext.DataRow[4].ToString();

            
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            driver_52_Phu_57_Qui.FindElement(By.LinkText("Đăng ký")).Click();
            
            driver_52_Phu_57_Qui.FindElement(By.Id("lastName")).SendKeys(lastName);
            driver_52_Phu_57_Qui.FindElement(By.Id("firstName")).SendKeys(firstName);
            driver_52_Phu_57_Qui.FindElement(By.Id("PhoneNumber")).SendKeys(phoneNumber);
            driver_52_Phu_57_Qui.FindElement(By.Id("email")).SendKeys(email);
            driver_52_Phu_57_Qui.FindElement(By.Id("password")).SendKeys(password);
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click();

            Thread.Sleep(10000);
            driver_52_Phu_57_Qui.Quit();
        }
       


    }
}
