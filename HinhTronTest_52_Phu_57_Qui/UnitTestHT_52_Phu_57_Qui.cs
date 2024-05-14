using _52_Phu_57_Qui_NUNIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HinhTronTest_52_Phu_57_Qui
{
    [TestClass]
    public class UnitTestHT_52_Phu_57_Qui
    {
        public TestContext TestContext { get; set; } //Khai báo thuộc tính TestContext
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                          @".\Data_52_Phu_57_Qui\TestData_52_Phu_57_Qui.csv", "TestData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)] //Dẫn đường dẫn file csv

        [TestMethod]
        public void TinhChuViHinhTron_52_Phu_57_Qui()
        {
            double banKinh_52_Phu_57_Qui = double.Parse(TestContext.DataRow[0].ToString()); //Lấy giá trị dòng thứ nhất để gán vào biến bán kính
            double chuViDuKien_52_Phu_57_Qui = double.Parse(TestContext.DataRow[1].ToString()); //Lấy giá trị dòng thứ hai để gán vào biến chu vi dự kiến

            HinhTron_52_Phu_57_Qui tron_52_Phu_57_Qui = new HinhTron_52_Phu_57_Qui(banKinh_52_Phu_57_Qui);
            double chuViThucTe_52_Phu_57_Qui = tron_52_Phu_57_Qui.TinhChuVi_52_Phu_57_Qui(); //Lấy phương thức và gán vào biến chu vi thực tế
            Assert.AreEqual(chuViDuKien_52_Phu_57_Qui, chuViThucTe_52_Phu_57_Qui, 0.1); //So sánh giá trị chu vi tính toán thực tế với giá trị chu vi mong đợi từ dữ liệu với sai số chênh lệch là 0.1
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                          @".\Data_52_Phu_57_Qui\TestData_52_Phu_57_Qui.csv", "TestData_52_Phu_57_Qui#csv", DataAccessMethod.Sequential)]//Dẫn đường dẫn file csv
        [TestMethod]
        public void TinhDienTichHinhTron_52_Phu_57_Qui()
        {
            double banKinh_52_Phu_57_Qui = double.Parse(TestContext.DataRow[0].ToString()); //Lấy giá trị dòng thứ nhất để gán vào biến bán kính
            double dienTichDuKien_52_Phu_57_Qui = double.Parse(TestContext.DataRow[2].ToString()); //Lấy giá trị dòng thứ ba để gán vào biến diện tích dự kiến

            HinhTron_52_Phu_57_Qui tron_52_Phu_57_Qui = new HinhTron_52_Phu_57_Qui(banKinh_52_Phu_57_Qui);
            double dienTichThucTe_52_Phu_57_Qui = tron_52_Phu_57_Qui.TinhDienTich_52_Phu_57_Qui(); //Lấy phương thức và gán vào biến diện tích thực tế
            Assert.AreEqual(dienTichDuKien_52_Phu_57_Qui, dienTichThucTe_52_Phu_57_Qui, 0.1); //So sánh giá trị diện tích tính toán thực tế với giá trị tính toán mong đợi từ dữ liệu với sai số chênh lệch là 0.1
        }

    }
}

