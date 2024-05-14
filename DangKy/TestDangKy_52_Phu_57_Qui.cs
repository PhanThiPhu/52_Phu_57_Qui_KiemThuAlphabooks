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
        IWebDriver driver_52_Phu_57_Qui = new ChromeDriver();
        //Tạo hàm để điều hướng tới trình duyệt
        public void SetUp_52_Phu_57_Qui()
        {
            driver_52_Phu_57_Qui.Navigate().GoToUrl("https://www.alphabooks.vn/");

        }
        //Testcase 1 Đăng ký tài khoản thành công 
        [TestMethod]
        public void TestCase1_DangKyThanhCong_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui();
            Thread.Sleep(1000);

            //Lấy element của Tài khoản và Đăng ký
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            driver_52_Phu_57_Qui.FindElement(By.LinkText("Đăng ký")).Click();

            //Lấy các element các thông tin để điền dữ liệu
            Thread.Sleep(1000);
            driver_52_Phu_57_Qui.FindElement(By.Id("lastName")).SendKeys("Phan");//element họ
            driver_52_Phu_57_Qui.FindElement(By.Id("firstName")).SendKeys("Phu");//element tên
            driver_52_Phu_57_Qui.FindElement(By.Id("PhoneNumber")).SendKeys("0345678910");//element số điện thoại
            driver_52_Phu_57_Qui.FindElement(By.Id("email")).SendKeys("2151050334@ou.edu.vn");//element email
            driver_52_Phu_57_Qui.FindElement(By.Id("password")).SendKeys("12345678");//element mật khẩu
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click();//element nút đăng ký

            //Dừng 10s rồi tắt trình duyệt 
            Thread.Sleep(10000);
            driver_52_Phu_57_Qui.Quit();
        }
        public TestContext TestContext { get; set; } //Khai báo thuộc tính TestContext

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                         @".\RegisterData_52_Phu_57_Qui\TestRegisterData_52_Phu_57_Qui.csv", "TestRegisterData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)] //Đường dẫn file .csv

        //Test case 2 Đăng ký tài khoản thất bại 
        public void TestCase2_DangKyThatBai_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui();
            //Lấy giá trị từng dòng file .csv để gán vào mỗi biến 
            string lastName = TestContext.DataRow[0].ToString();//họ
            string firstName = TestContext.DataRow[1].ToString();//tên
            string phoneNumber = TestContext.DataRow[2].ToString();//số điện thoại
            string email = TestContext.DataRow[3].ToString();//email
            string password = TestContext.DataRow[4].ToString();//mật khẩu

            ////Lấy element của Tài khoản và Đăng ký
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            driver_52_Phu_57_Qui.FindElement(By.LinkText("Đăng ký")).Click();

            //Lấy các element các thông tin để lấy dữ liệu từ file .csv
            driver_52_Phu_57_Qui.FindElement(By.Id("lastName")).SendKeys(lastName);//element họ
            driver_52_Phu_57_Qui.FindElement(By.Id("firstName")).SendKeys(firstName);//element tên
            driver_52_Phu_57_Qui.FindElement(By.Id("PhoneNumber")).SendKeys(phoneNumber);//element số điện thoại
            driver_52_Phu_57_Qui.FindElement(By.Id("email")).SendKeys(email);//element email
            driver_52_Phu_57_Qui.FindElement(By.Id("password")).SendKeys(password);//element mật khẩu
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click();//element đăng ký

            //Dừng 10s rồi tắt trình duyệt 
            Thread.Sleep(10000);
            driver_52_Phu_57_Qui.Quit();
        }
    }
}
