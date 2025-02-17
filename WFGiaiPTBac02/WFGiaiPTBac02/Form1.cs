using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGiaiPTBac02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double A, B, C;
            try
            {
                A = double.Parse(txtA.Text);
                B = double.Parse(txtB.Text);
                C = double.Parse(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi");
                return;
            }

            double delta = B * B - 4 * A * C;
            if (delta > 0)
            {
                double x1 = Math.Round((-2 * B - Math.Sqrt(delta)) / (2 * A), 2);
                double x2 = Math.Round((-2 * B + Math.Sqrt(delta)) / (2 * A), 2);
                txtKetQua.Text = $"Phương trình có 2 nghiệm phân biệt:\r\nx1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                txtKetQua.Text = $"Phương trình có nghiệm kép: x = {-B / (2 * A)}";
            }
            else
            {
                txtKetQua.Text = "Phương trình vô nghiệm";
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Text = "";
            txtC.Clear();
            txtKetQua.Clear();

            //đưa dấu nháy vô txtA để nhập
            txtA.Focus();
        }
    }
}
