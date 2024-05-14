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

        IWebDriver driver_52_Phu_57_Qui; // Khai báo biến điều khiển trình duyệt.

        [TestInitialize]

        public void Initialize_52_Phu_57_Qui()
        {
            driver_52_Phu_57_Qui = new ChromeDriver(); // Khởi tạo trình duyệt Chrome.
        }

        public void SetUp_52_Phu_57_Qui()
        {
            driver_52_Phu_57_Qui.Navigate().GoToUrl("https://www.alphabooks.vn/"); // Điều hướng đến trang web AlphaBooks.
        }

        [TestMethod]
        // TC1 Quên mật khẩu thành công
        public void TC1_QuenMatKhauThanhCong_52_Phu_57_Qui()
        {
            SetUp_52_Phu_57_Qui(); // Gọi phương thức SetUp để thiết lập trang web.
            Thread.Sleep(1000); // Dừng 1 giây.
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img")); // Tìm và chọn phần tử nút "Đăng nhập".
            Button_Human_52_Phu_57_Qui.Click(); // Click vào nút "Đăng nhập".
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement QuenMatKhau_VaoDay_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > main > div > div > div > div > div > div.left-col > div.group-login.group-log > p > a")); // Tìm và chọn liên kết "Quên mật khẩu".
            QuenMatKhau_VaoDay_52_Phu_57_Qui.Click(); // Click vào liên kết "Quên mật khẩu".
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement RecoverEmail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("recover-email")); // Tìm ô nhập email để khôi phục mật khẩu.
            RecoverEmail_52_Phu_57_Qui.SendKeys("ngquiofficial@gmail.com"); // Nhập email cần khôi phục mật khẩu.
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement Button_SendMail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[2]/form/input[3]")); // Tìm và chọn nút gửi email khôi phục mật khẩu.
            Button_SendMail_52_Phu_57_Qui.Click(); // Click vào nút gửi email khôi phục mật khẩu.
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement QuenMatKhau_VaoDay2_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[1]/p/a")); // Tìm và chọn liên kết khác để quay lại trang đăng nhập.
            QuenMatKhau_VaoDay2_52_Phu_57_Qui.Click(); // Click vào liên kết để quay lại trang đăng nhập.
            Thread.Sleep(5000); // Dừng 5 giây.
            driver_52_Phu_57_Qui.Quit(); // Đóng trình duyệt.
        }


        public TestContext TestContext { get; set; } // Thuộc tính cung cấp thông tin về ngữ cảnh của bài kiểm thử.
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\ForgotPasswordData_52_Phu_57_Qui\ForgotPasswordData_52_Phu_57_Qui.csv", "ForgotPasswordData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]
        // TC2 Quên mật khẩu không thành công
        // TC2.1 Quên mật khẩu không thành công (Nhập email không có trong CSDL)
        // TC2.2 Quên mật khẩu không thành công (Nhập sai đuôi gmail)
        // TC2.3 Quên mật khẩu không thành công (Chỉ nhập đầu gmail)
        // TC2.4 Quên mật khẩu không thành công (Chỉ nhập đuôi gmail)
        // TC2.5 Quên mật khẩu không thành công (Không nhập gmail)
        // TC2.6 Quên mật khẩu không thành côngu (Nhập kí tự đặc biệt trước đuôi gmail)
        // TC2.7 Quên mật khẩu không thành công (Nhập kí tự @ trước đuôi gmail)
        public void TC2_QuenMatKhauKhongThanhCong_52_Phu_57_Qui()
        {
            var email = TestContext.DataRow[0].ToString(); //Email

            SetUp_52_Phu_57_Qui(); // Gọi phương thức SetUp để thiết lập trang web.
            Thread.Sleep(1000); // Dừng 1 giây.
            IWebElement Button_Human_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/header/div/div/div[2]/div[1]/div[2]/div/div[2]/a/img")); // Tìm và chọn phần tử nút "Đăng nhập".
            Button_Human_52_Phu_57_Qui.Click(); // Click vào nút "Đăng nhập".
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement QuenMatKhau_VaoDay_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.CssSelector("body > main > div > div > div > div > div > div.left-col > div.group-login.group-log > p > a")); // Tìm và chọn liên kết "Quên mật khẩu".
            QuenMatKhau_VaoDay_52_Phu_57_Qui.Click(); // Click vào liên kết "Quên mật khẩu".
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement RecoverEmail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.Id("recover-email")); // Tìm ô nhập email để khôi phục mật khẩu.
            RecoverEmail_52_Phu_57_Qui.SendKeys(email); // Nhập email từ tập tin dữ liệu.
            Thread.Sleep(2000); // Dừng 2 giây.
            IWebElement Button_SendMail_52_Phu_57_Qui = driver_52_Phu_57_Qui.FindElement(By.XPath("/html/body/main/div/div/div/div/div/div[1]/div[2]/form/input[3]")); // Tìm và chọn nút gửi email khôi phục mật khẩu.
            Button_SendMail_52_Phu_57_Qui.Click(); // Click vào nút gửi email khôi phục mật khẩu.
            Thread.Sleep(5000); // Dừng 5 giây.
            driver_52_Phu_57_Qui.Quit(); // Đóng trình duyệt.
        }
    }
}
