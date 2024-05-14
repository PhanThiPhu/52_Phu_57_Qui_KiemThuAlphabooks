using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace QuenMatKhau_52_Phu_57_Qui
{
    [TestClass]
    public class QuenMatKhau_52_Phu_57_Qui
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
        public void TC1_52_Phu_57_Qui()
        {
            SetUp();
            Thread.Sleep(1000);
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            Thread.Sleep(2000);
            IWebElement QuenMatKhau_VaoDay_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > main > div > div > div > div > div > div.left-col > div.group-login.group-log > p > a"));
            QuenMatKhau_VaoDay_52_Phu_57_Qui.Click();
            Thread.Sleep(2000);
            IWebElement RecoverEmail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("recover-email"));
            RecoverEmail_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com");
            Thread.Sleep(2000);
            IWebElement Button_SendMail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[2]/form/input[3]"));
            Button_SendMail_52_Phu_57_Qui.Click();
            Thread.Sleep(3000);
            IWebElement QuenMatKhau_VaoDay2_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[1]/p/a"));
            QuenMatKhau_VaoDay2_52_Phu_57_Qui.Click();
            Thread.Sleep(5000);
            driver_52_Phu_57_Qui.Quit();
        }


        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\ForgotPasswordData_52_Phu_57_Qui\ForgotPasswordData_52_Phu_57_Qui.csv", "ForgotPasswordData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]
        public void TC2_52_Phu_57_Qui()
        {
            var email = TestContext.DataRow[0].ToString(); //Email

            SetUp();
            Thread.Sleep(1000);
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            Thread.Sleep(2000);
            IWebElement QuenMatKhau_VaoDay_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > main > div > div > div > div > div > div.left-col > div.group-login.group-log > p > a"));
            QuenMatKhau_VaoDay_52_Phu_57_Qui.Click();
            Thread.Sleep(2000);
            IWebElement RecoverEmail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("recover-email"));
            RecoverEmail_52_Phu_57_Qui.SendKeys(email);
            Thread.Sleep(2000);
            IWebElement Button_SendMail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[2]/form/input[3]"));
            Button_SendMail_52_Phu_57_Qui.Click();
            Thread.Sleep(5000);
            driver_52_Phu_57_Qui.Quit();

        }

    }
}
