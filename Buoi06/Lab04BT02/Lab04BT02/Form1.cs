namespace Lab04BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int dong = 1, cot = 1;
            if (!int.TryParse(txtSoDong.Text, out dong) || dong < 1)
            {
                MessageBox.Show("Nhập lại dòng");
                txtSoDong.Focus();
                return;
            }
            if (!int.TryParse(txtSoCot.Text, out cot) || cot < 1)
            {
                MessageBox.Show("Nhập lại cột");
                txtSoCot.Focus();
                return;
            }
            var myForm = new frmXuat(dong, cot);
            myForm.Show();
        }
    }
}
