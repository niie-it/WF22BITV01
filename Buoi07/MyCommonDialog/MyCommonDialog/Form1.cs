namespace MyCommonDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGhiFile_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Title = "Lưu file";
            dlg.Filter = "Văn bản|*.txt|File của tui|*.my";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dlg.FileName);
                File.WriteAllText(dlg.FileName, TxtVanBan.Text);
            }
        }

        private void BtnDocFile_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Mở file";
            dlg.Filter = "Văn bản|*.txt|File của tui|*.my";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            var fontDlg = new FontDialog();
            fontDlg.ShowApply = true;
            fontDlg.Apply += new EventHandler(XuLyAppyFont);
            fontDlg.ShowColor = true;
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.Font = fontDlg.Font;
                TxtVanBan.ForeColor = fontDlg.Color;
            }
        }

        private void XuLyAppyFont(object? sender, EventArgs e)
        {
            var dlg = sender as FontDialog;
            TxtVanBan.Font = dlg.Font;
            TxtVanBan.ForeColor = dlg.Color;
        }

        private void BtnDoiMau_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.BackColor = colorDlg.Color;
            }
        }
    }
}
