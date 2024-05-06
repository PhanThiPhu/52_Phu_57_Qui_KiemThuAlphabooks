using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Phu_57_Qui_NUNIT
{
    public class HinhTron_52_Phu_57_Qui
    {
        private double banKinh_52_Phu_57_Qui; //Khai báo biến dữ liệu bán kính 
        public HinhTron_52_Phu_57_Qui(double banKinh_52_Phu_57_Qui)
        {
            this.banKinh_52_Phu_57_Qui = banKinh_52_Phu_57_Qui; //Gán giá trị của tham số vào biến dữ liệu

        }
        public double TinhChuVi_52_Phu_57_Qui()
        {
            double chuVi_52_Phu_57_Qui = 2 * Math.PI * banKinh_52_Phu_57_Qui; //Công thức tính chu vi hình tròn
            return Math.Round(chuVi_52_Phu_57_Qui, 2); //Làm tròn kết quả chu vi lên 2 chữ số thập phân
        }
        public double TinhDienTich_52_Phu_57_Qui()
        {
            double dienTich_52_Phu_57_Qui = Math.PI * banKinh_52_Phu_57_Qui * banKinh_52_Phu_57_Qui; //Công thức tính diện tích hình tròn
            return Math.Round(dienTich_52_Phu_57_Qui, 2); //Làm tròn kết quả diện tích lên 2 chữ số thập phân
        }
    }
}
