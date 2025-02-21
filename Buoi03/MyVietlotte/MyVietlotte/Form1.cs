namespace MyVietlotte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            int maxValue = rad645.Checked ? 45 : 55;

            var rd = new Random();
            while (list.Count < 6)
            {
                int soSinhRa = rd.Next(1, maxValue + 1);
                if (!list.Contains(soSinhRa))
                {
                    list.Add(soSinhRa);
                }
            }

            list.Sort();
            txtKetQua.Text = string.Join(", ", list);
        }
    }
}
