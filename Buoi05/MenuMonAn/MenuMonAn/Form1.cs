namespace MenuMonAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTenMon_KeyUp(object sender, KeyEventArgs e)
        {
            btnThem.Enabled = txtTenMon.Text.Trim().Length > 0 ? true : false;
        }

        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Bấm Enter
            {
                btnThem_Click(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenMon = txtTenMon.Text.Trim();
            if (!lstThucDon.Items.Contains(tenMon))
            {
                lstThucDon.Items.Add(tenMon);
                txtTenMon.Clear();
            }
            else
            {
                MessageBox.Show($"Đã có {tenMon} trong MENU");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (var item in lstThucDon.SelectedItems)
            {
                if (!lstChon.Items.Contains(item.ToString()))
                {
                    lstChon.Items.Add(item.ToString());
                }
            }
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            lstChon.Items.Clear();
            foreach (var item in lstThucDon.Items)
            {
                lstChon.Items.Add(item.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstChon.SelectedItems.Count > 0)
            {
                lstChon.Items.Remove(lstChon.SelectedItem);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstChon.Items.Clear();
        }

        
    }
}
