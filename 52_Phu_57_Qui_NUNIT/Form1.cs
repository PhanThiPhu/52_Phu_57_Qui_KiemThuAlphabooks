using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52_Phu_57_Qui_NUNIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double banKinh_52_Phu_57_Qui, chuVi_52_Phu_57_Qui, dienTich_52_Phu_57_Qui; //Khai báo 3 biến
            banKinh_52_Phu_57_Qui = double.Parse(txtBanKinh.Text); //Lấy giá trị từ txt gán vào biến
            HinhTron_52_Phu_57_Qui tron_52_Phu_57_Qui = new HinhTron_52_Phu_57_Qui(banKinh_52_Phu_57_Qui); //Tạo một đối tượng mới

            chuVi_52_Phu_57_Qui = tron_52_Phu_57_Qui.TinhChuVi_52_Phu_57_Qui(); //Lấy phương thức và gán vào biến chu vi
            dienTich_52_Phu_57_Qui = tron_52_Phu_57_Qui.TinhDienTich_52_Phu_57_Qui(); //Lấy phương thức và gán vào biến diện tích

            txtChuVi.Text = chuVi_52_Phu_57_Qui.ToString(); //Hiển thị kết quả chu vi vào ô txt
            txtDienTich.Text = dienTich_52_Phu_57_Qui.ToString(); //Hiển thị kết quả diện tích vào ô txt

        }
    }
}
