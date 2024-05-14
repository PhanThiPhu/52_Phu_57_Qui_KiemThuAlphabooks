﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void Initialize_52_Phu_57_Qui()
        {
            // Khởi tạo WebDriver
            driver_52_Phu_57_Qui = new ChromeDriver();
        }

        public void SetUp_52_Phu_57_Qui()
        {
            // Điều hướng đến trang web alphabooks
            driver_52_Phu_57_Qui.Navigate().GoToUrl("https://www.alphabooks.vn/");

        }
        [TestMethod]
        //TC1 Đổi mật khẩu thành công
        public void TC1_DoiMatKhauThanhCong_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui();
            Thread.Sleep(1000);
            // Tìm và nhấp vào nút vào giao diện đăng nhập
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            // Tìm và nhập email vào trường tài khoản
            IWebElement Account_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("input[type='email']"));
            Account_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com");
            // Tìm và nhập văn bản vào trường mật khẩu
            IWebElement Password_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("customer_password"));
            Password_52_Phu_57_Qui.SendKeys("123456789aA");
            // Tìm và nhấp vào nút đăng nhập
            IWebElement BtnLogIn_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login"));
            BtnLogIn_52_Phu_57_Qui.Click();
            // Tìm và nhấp vào nút đổi mật khẩu
            IWebElement BtnDoiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.LinkText("Đổi mật khẩu"));
            BtnDoiMatKhau_52_Phu_57_Qui.Click();
            // Tìm và nhập văn bản vào trường mật khẩu hiện tại
            IWebElement Oldpass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Name("OldPassword"));
            Oldpass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            // Tìm và nhập văn bản vào trường mật khẩu mới
            IWebElement newPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("changePass"));
            newPass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            // Tìm và nhập văn bản vào trường xác nhận mật khẩu
            IWebElement confirmPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("confirmPass"));
            confirmPass_52_Phu_57_Qui.SendKeys("123456789aA");
            Thread.Sleep(1000);
            // Tìm và nhấp vào nút đặt lại mật khẩu
            IWebElement buttonDatLaiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("button-default"));
            buttonDatLaiMatKhau_52_Phu_57_Qui.Click();
            Thread.Sleep(3000);
            // Kết thúc Test Case đóng trình duyệt
            driver_52_Phu_57_Qui.Quit();
        }


        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DoiMatKhauData_52_Phu_57_Qui\DoiMatKhauData_52_Phu_57_Qui.csv", "DoiMatKhauData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]
        //TC2 Đổi mật khẩu thất bại
        //TC2.1 Đổi mật khẩu thất bại (Nhập sai mật khẩu cũ)
        //TC2.2 Đổi mật khẩu thất bại (Mật khẩu mới quá ngắn)
        //TC2.3 Đổi mật khẩu thất bại (Không nhập trường mật khẩu mới)
        //TC2.4 Đổi mật khẩu thất bại (Không nhập trường xác nhận mật khẩu)
        //TC2.5 Đổi mật khẩu thất bại (Không nhập trường mật khẩu cũ)
        //TC2.6 Đổi mật khẩu thất bại (Hai trường xác nhận mật khẩu không trùng nhau)
        public void TC2_DoiMatKhauThatBai_52_Phu_57_Qui()
        {

            var oldPass_52_Phu_57_Qui = TestContext.DataRow[0].ToString(); //Khai báo biến mật khẩu hiện tại
            var newPass_52_Phu_57_Qui = TestContext.DataRow[1].ToString(); //Khai báo biến mật khẩu mới
            var confirmPass_52_Phu_57_Qui = TestContext.DataRow[2].ToString(); //Khai báo biến xác nhận mật khẩu

            SetUp_52_Phu_57_Qui();
            Thread.Sleep(1000);
            // Tìm và nhấp vào nút vào giao diện đăng nhập
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img"));
            Button_Human_52_Phu_57_Qui.Click();
            // Tìm và nhập email vào trường tài khoản
            IWebElement Account_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("input[type='email']"));
            Account_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com");
            // Tìm và nhập văn bản vào trường mật khẩu
            IWebElement Password_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("customer_password"));
            Password_52_Phu_57_Qui.SendKeys("123456789aA");
            // Tìm và nhấp vào nút đăng nhập
            IWebElement BtnLogIn_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login"));
            BtnLogIn_52_Phu_57_Qui.Click();
            // Tìm và nhấp vào nút đổi mật khẩu
            IWebElement BtnDoiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.LinkText("Đổi mật khẩu"));
            BtnDoiMatKhau_52_Phu_57_Qui.Click();
            // Tìm và nhập văn bản vào trường mật khẩu hiện tại
            IWebElement Oldpass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Name("OldPassword"));
            Oldpass_52_Phu_57_Qui.SendKeys(oldPass_52_Phu_57_Qui);
            Thread.Sleep(1000);
            // Tìm và nhập văn bản vào trường mật khẩu mới
            IWebElement NewPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("changePass"));
            NewPass_52_Phu_57_Qui.SendKeys(newPass_52_Phu_57_Qui);
            Thread.Sleep(1000);
            // Tìm và nhập văn bản vào trường xác nhận mật khẩu
            IWebElement ConfirmPass_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("confirmPass"));
            ConfirmPass_52_Phu_57_Qui.SendKeys(confirmPass_52_Phu_57_Qui);
            Thread.Sleep(1000);
            // Tìm và nhấp vào nút đặt lại mật khẩu
            IWebElement buttonDatLaiMatKhau_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.ClassName("button-default"));
            buttonDatLaiMatKhau_52_Phu_57_Qui.Click();
            Thread.Sleep(3000);
            // Kết thúc Test Case đóng trình duyệt
            driver_52_Phu_57_Qui.Quit();
        }
    }
}