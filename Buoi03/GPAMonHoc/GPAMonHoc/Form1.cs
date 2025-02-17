using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPAMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double ChuyenCan, ThucHanh, DoAn;
            if (!double.TryParse(txtChuyenCan.Text, out ChuyenCan) || (ChuyenCan < 0) || (ChuyenCan > 10))
            {
                MessageBox.Show("Điểm chuyên cần chưa hợp lệ. Nhập lại.");
                txtChuyenCan.Focus();
                return;
            }
            if (!double.TryParse(txtThucHanh.Text, out ThucHanh) || (ThucHanh < 0) || (ThucHanh > 10))
            {
                MessageBox.Show("Điểm thực hành chưa hợp lệ. Nhập lại.");
                txtThucHanh.Focus();
                return;
            }
            if (!double.TryParse(txtDoAn.Text, out DoAn) || (DoAn < 0) || (DoAn > 10))
            {
                MessageBox.Show("Điểm chuyên cần chưa hợp lệ. Nhập lại.");
                txtDoAn.Focus();
                return;
            }

            double DTB = 0;
            if (DoAn < 4)
            {
                DTB = DoAn;
            }
            else
            {
                DTB = Math.Round(ChuyenCan * 0.2 + ThucHanh * 0.2 + DoAn * 0.6, 1);
            }

            char GPA;
            string Loai;
            if (DTB < 4) { GPA = 'F'; Loai = "Rớt"; }
            else if (DTB < 5.5) { GPA = 'D'; Loai = "Yếu";  }
            else if (DTB < 7) { GPA = 'C'; Loai = "TB"; }
            else if (DTB < 8.5) { GPA = 'B'; Loai = "Khá"; }
            else { GPA = 'A'; Loai = "Giỏi"; }
            txtKetQua.Text = $"ĐTB: {DTB}, GPA: {GPA}, Kết quả: {Loai}";
        }
    }
}
