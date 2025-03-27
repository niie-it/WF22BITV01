using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07QLHS
{
    public partial class FrmQLLop : Form
    {
        public FrmQLLop()
        {
            InitializeComponent();
        }

        void loadDanhSach()
        {
            lvLop.Items.Clear();
            var dtLop = DataProvider.TruyVan_LayDuLieu("SELECT * FROM Lop");
            foreach (DataRow item in dtLop.Rows)
            {
                var malop = item["MaLop"].ToString();
                var tenlop = item["TenLop"].ToString();
                var siso = item["SiSo"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = malop;
                lvi.Text = malop;
                lvi.SubItems.Add(tenlop);
                lvi.SubItems.Add(siso);
                lvLop.Items.Add(lvi);
            }
        }

        private void FrmQLLop_Load(object sender, EventArgs e)
        {
            loadDanhSach();
        }

        private void CboListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLop.View = (View)CboListType.SelectedIndex;
        }

        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvLop_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtMaLop.Text = e.Item.Text;
            txtTenLop.Text = e.Item.SubItems[1].Text;
            txtSiSo.Text = e.Item.SubItems[2].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            int siSo = int.Parse(txtSiSo.Text);

            string sql = "INSERT INTO Lop(MaLop, TenLop, SiSo) VALUES (@MaLop,@TenLop, @SiSo)";
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@MaLop", maLop);
            pa[1] = new SqlParameter("@TenLop", tenLop);
            pa[2] = new SqlParameter("@SiSo", SqlDbType.Int);
            pa[2].Value = siSo;
            try
            {
                DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
                loadDanhSach();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = lvLop.SelectedItems[0].Tag.ToString();
            var dlg = MessageBox.Show($"Chắc xóa lớp {maLop}", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                var sql = "delete from Lop where MaLop = @MaLop";
                SqlParameter[] pa = new SqlParameter[1];
                pa[0] = new SqlParameter("@MaLop", maLop);
                try
                {
                    DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
                    MessageBox.Show($"Xóa lớp {maLop} thành công!");
                    loadDanhSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}");
                }
            }
        }
    }
}
