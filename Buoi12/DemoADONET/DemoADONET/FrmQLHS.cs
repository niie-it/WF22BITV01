using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADONET
{
    public partial class FrmQLHS : Form
    {
        public FrmQLHS()
        {
            InitializeComponent();
        }

        private void FrmQLHS_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Lop";
            CboLop.DataSource = DataProvider.TruyVan_LayDuLieu(sql);
            CboLop.DisplayMember = "TenLop";
            CboLop.ValueMember = "MaLop";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var sqlInsert = $"INSERT INTO HocSinh(MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES(N'{TxtMaHS.Text}', N'{TxtHoTen.Text}', '{DtpNgaySinh.Value.ToString("yyyy-MM-dd")}', N'{TxtDiaChi.Text}', {TxtDiemTB.Text}, '{CboLop.SelectedValue}')";
            MessageBox.Show(sqlInsert);
            DataProvider.TruyVan_XuLy(sqlInsert);
        }
    }
}
