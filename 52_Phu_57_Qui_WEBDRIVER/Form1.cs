using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace _52_Phu_57_Qui_WEBDRIVER
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private const string webURL = "https://www.alphabooks.vn/";

        //_57_Qui_52_Phu
        public Form1()
        {
            InitializeComponent();

        }
        //_57_Qui_52_Phu
        private void Navigate()
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl(webURL);
        }
        private void SignInWithRightAccount()
        {
            IWebElement HumanButton = driver.FindElement(By.XPath(" (/ html / body / header / div / div / div[2] / div[1] / div[2] / div / div[2] / a)"));
            HumanButton.Click();
            IWebElement account = driver.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[1]/form/fieldset[1]/input"));
            account.SendKeys("ngquiofficial@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[1]/form/fieldset[2]/input"));
            password.SendKeys("123456789aA");
            IWebElement SignInButton = driver.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[1]/form/button"));
            SignInButton.Click();
        }
        //52_Phú




        //57_Quí
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Navigate();
            SignInWithRightAccount();
        }
    }
}
