namespace DemoSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> sinhViens = new List<SinhVien>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            //tự check hợp lệ dữ liệu
            SinhVien sv = new SinhVien(txtMaSV.Text, txtHoTen.Text, txtDienThoai.Text, double.Parse(txtGPA.Text));

            //LINQ để check xem danh sách SV đã có mã đó hay chưa
            SinhVien sinhVien = sinhViens.SingleOrDefault(s => s.MaSV == sv.MaSV);
            if (sinhVien == null)
            {
                sinhViens.Add(sv);
            }
            else
            {
                MessageBox.Show($"Đã có SV mã {sv.MaSV}");
            }

            hienThiDanhSach();
        }

        void hienThiDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhViens;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Chắc xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.No) { return; }
            //dựa vào mã SV để xóa
            SinhVien sv = sinhViens.SingleOrDefault(s => s.MaSV == txtMaSV.Text);
            if (sv == null)
            {
                MessageBox.Show($"Không có SV nào có mã {txtMaSV.Text}");
            }
            else
            {
                sinhViens.Remove(sv);
                hienThiDanhSach();
                MessageBox.Show("Đã xóa!!!");
            }
        }

        private void t_Click(object sender, EventArgs e)
        {
            SinhVien sv = sinhViens.SingleOrDefault(s => s.MaSV == txtMaSV.Text);
            if (sv != null)
            {
                sv.HoTen = txtHoTen.Text;
                sv.DienThoai = txtDienThoai.Text;
                sv.GPA = double.Parse(txtGPA.Text);

                hienThiDanhSach();
            }
        }
    }
}
