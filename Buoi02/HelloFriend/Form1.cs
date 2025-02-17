namespace HelloFriend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = $"Xin chào {txtHoTen.Text}";
        }

        private void XuLyThoat(object sender, EventArgs e)
        {
            var TraLoi = MessageBox.Show("Bạn chắc đóng không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TraLoi == DialogResult.Yes)
            {
                Application.Exit();//đóng ứng dụng
                //Close();//đóng form hiện tại
            }
        }
    }
}
