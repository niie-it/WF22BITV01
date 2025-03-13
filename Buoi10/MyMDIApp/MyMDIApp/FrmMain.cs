namespace MyMDIApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmLogin();
            //f.MdiParent = this;
            if (f.ShowDialog() == DialogResult.OK)
            {
                HienThiMenu(true);
                lblThongTin.Text = $"Xin chào: {f.Tag}";
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmEmployee();
            f.MdiParent = this;
            f.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void đóngTấtCảFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                form.Close();
            }
        }

        public void HienThiMenu(bool giaTri = true)
        {
            mnuDangNhap.Enabled = !giaTri;
            mnuDangXuat.Enabled = giaTri;
            mnuQuanLyNhanVien.Visible = giaTri;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu(false);
        }
    }
}
