namespace Lab07QLHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnuDanhMucLop_Click(object sender, EventArgs e)
        {
            var f = new FrmQLLop();
            f.MdiParent = this;
            f.Show();
        }
    }
}
