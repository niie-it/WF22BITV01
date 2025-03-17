using System.Data;
using System.Data.SqlClient;

namespace DemoADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = "Server=.;Database=QLHS22BITV01;Integrated Security=True;";
        private void Form1_Load(object sender, EventArgs e)
        {
            var conn = new SqlConnection(chuoiKetNoi);
            var sql = "SELECT MaHS, TenHS, DTB, hs.MaLop, TenLop\r\nFROM HocSinh hs JOIN Lop l ON hs.MaLop = l.MaLop\r\nORDER BY TenHS";
            var da = new SqlDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
