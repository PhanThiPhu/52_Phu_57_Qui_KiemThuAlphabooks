using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DoiMatKhau_52_Phu_57_Qui
{
    [TestClass]
    public class DoiMatKhau_52_Phu_57_Qui
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
        public void TC1_DoiMatKhauThanhCong_52_Phu_57_Qui()
        {
            SetUp();
            Thread.Sleep(1000);
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            IWebElement Account_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("input[type='email']"));
            Account_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com");
            IWebElement Password_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("customer_password"));
            Password_52_Phu_57_Qui.SendKeys("123456789aA");
            IWebElement BtnLogIn_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login"));
            BtnLogIn_52_Phu_57_Qui.Click();
            IWebElement BtnDoiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.LinkText("Đổi mật khẩu"));
            BtnDoiMatKhau_52_Phu_57_Qui.Click();
            IWebElement Oldpass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Name("OldPassword"));
            Oldpass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            IWebElement newPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("changePass"));
            newPass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            IWebElement confirmPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("confirmPass"));
            confirmPass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            IWebElement buttonDefault_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("button-default"));
            buttonDefault_52_Phu_57_Qui.Click();
            Thread.Sleep(3000);
            driver_52_Phu_57_Qui.Quit();
        }



        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DoiMatKhauData_52_Phu_57_Qui\DoiMatKhauData_52_Phu_57_Qui.csv", "DoiMatKhauData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]
        public void TC2_DoiMatKhauThatBai_52_Phu_57_Qui()
        {
            var oldPass = TestContext.DataRow[0].ToString();
            var newPass = TestContext.DataRow[1].ToString(); //Email
            var confirmPass = TestContext.DataRow[2].ToString(); //Email


            SetUp();
            Thread.Sleep(1000);
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            IWebElement Account_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("input[type='email']"));
            Account_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com");
            IWebElement Password_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("customer_password"));
            Password_52_Phu_57_Qui.SendKeys("123456789aA");
            IWebElement BtnLogIn_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login"));
            BtnLogIn_52_Phu_57_Qui.Click();
            IWebElement BtnDoiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.LinkText("Đổi mật khẩu"));
            BtnDoiMatKhau_52_Phu_57_Qui.Click();
            IWebElement Oldpass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Name("OldPassword"));
            Oldpass_52_Phu_57_Qui.SendKeys(oldPass);
            Thread.Sleep(1000);
            IWebElement newPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("changePass"));
            newPass_52_Phu_57_Qui.SendKeys(newPass);
            Thread.Sleep(1000);
            IWebElement confirmPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("confirmPass"));
            confirmPass_52_Phu_57_Qui.SendKeys(confirmPass);
            Thread.Sleep(1000);
            IWebElement buttonDefault_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("button-default"));
            buttonDefault_52_Phu_57_Qui.Click();
            Thread.Sleep(3000);
            driver_52_Phu_57_Qui.Quit();
        }

        

        

    }
}
