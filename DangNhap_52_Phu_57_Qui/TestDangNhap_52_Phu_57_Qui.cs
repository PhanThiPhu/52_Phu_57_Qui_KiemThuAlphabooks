using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DangNhap_52_Phu_57_Qui
{
    [TestClass]
    public class TestDangNhap_52_Phu_57_Qui
    {
        IWebDriver driver_52_Phu_57_Qui = new ChromeDriver();
        //Tạo hàm để điều hướng tới trình duyệt
        public void SetUp_52_Phu_57_Qui()
        {
            driver_52_Phu_57_Qui.Navigate().GoToUrl("https://www.alphabooks.vn/");
        }

        //Testcase 1 Đăng nhập tài khoản thành công
        [TestMethod]
        public void TestCase1_DangNhapThanhCong_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui();
            Thread.Sleep(1000);
            //Lấy element của Tài khoản 
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            Thread.Sleep(1000);
            //Lấy các element các thông tin để điền dữ liệu
            driver_52_Phu_57_Qui.FindElement(By.Id("customer_email")).SendKeys("2151050334@ou.edu.vn");//element email
            driver_52_Phu_57_Qui.FindElement(By.Id("customer_password")).SendKeys("12345678");//element mật khẩu

            Thread.Sleep(3000);
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click(); //element nút đăng nhập
            //Dừng 10s rồi tắt trình duyệt 
            //so sánh 2 link có đạt được như ý muốn
            string expected_url_52_Phu_57_Qui = "https://www.alphabooks.vn/account";//khai báo url mong đợi
            string actual_url_52_Phu_57_Qui = driver_52_Phu_57_Qui.Url; //khai báo url thực tết
            Assert.AreEqual(expected_url_52_Phu_57_Qui, actual_url_52_Phu_57_Qui);//so sánh giá trị mong đợi và giá trị thực tế
            Thread.Sleep(6000);
            driver_52_Phu_57_Qui.Quit();
        }
        public TestContext TestContext { get; set; }//Khai báo thuộc tính TestContext

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                         @".\LoginData_52_Phu_57_Qui\TestLoginData_52_Phu_57_Qui.csv", "TestLoginData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]//Đường dẫn file .csv

        //Test case 2 Đăng nhập tài khoản thất bại
        //TC2.1 Đăng nhập tài khoản(Không nhập trường Email)
        //TC2.2 Đăng nhập tài khoản(Không nhập trường Mật khẩu)
        //TC2.3 Đăng nhập tài khoản(Không nhập cả 2 trường)
        //TC2.4 Đăng nhập tài khoản(Nhập sai trường Email)
        //TC2.5 Đăng nhập tài khoản(Nhập sai trường Mật khẩu)
        public void TestCase2_DangNhapThatBai_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui();
            //Lấy giá trị từng dòng file .csv để gán vào mỗi biến 
            string email = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            //Lấy element của Tài khoản 
            driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > header > div > div > div.col-9.col-md-9.order-md-1 > div.header_nav_main > div.navigation-head > div > div.account > a > img")).Click();
            Thread.Sleep(1000);

            //Lấy các element các thông tin để điền dữ liệu
            driver_52_Phu_57_Qui.FindElement(By.Id("customer_email")).SendKeys(email);//element email
            driver_52_Phu_57_Qui.FindElement(By.Id("customer_password")).SendKeys(password);//element mật khẩu

            Thread.Sleep(3000);
            driver_52_Phu_57_Qui.FindElement(By.ClassName("btn-login")).Click();//element nút đăng nhập
            //so sánh 2 link có đạt được như mong muốn
            string expected_url_52_Phu_57_Qui = "https://www.alphabooks.vn/account";//khai báo url mong đợi
            string actual_url_52_Phu_57_Qui = driver_52_Phu_57_Qui.Url; //khai báo url thực tế
            Assert.AreNotEqual(expected_url_52_Phu_57_Qui, actual_url_52_Phu_57_Qui);//so sánh giá trị mong đợi và thực tế

            //Dừng 10s rồi tắt trình duyệt 
            Thread.Sleep(6000);
            driver_52_Phu_57_Qui.Quit();
        }
    }
}
