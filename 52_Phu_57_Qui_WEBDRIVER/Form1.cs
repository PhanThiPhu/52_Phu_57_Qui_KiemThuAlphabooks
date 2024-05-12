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
        private void navigate()
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl(webURL);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            navigate();
        }
    }
}
