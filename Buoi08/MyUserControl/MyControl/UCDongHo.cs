using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyControl
{
    public partial class UCDongHo : UserControl
    {
        public UCDongHo()
        {
            InitializeComponent();
        }

        DateTime startTime;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)//đang chạy
            {
                timer1.Enabled = false;
                btnLap.Enabled = false;
                btnStartStop.Text = "START";
            }
            else
            {
                timer1.Enabled = true;
                btnLap.Enabled = true;
                btnStartStop.Text = "STOP";
                startTime = DateTime.Now;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var myTime = DateTime.Now.Subtract(startTime);
            lblDongHo.Text = $"{myTime.Hours.ToString("00")}:{myTime.Minutes.ToString("00")}:{myTime.Seconds.ToString("00")} {myTime.Milliseconds.ToString("000")}";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //ghi thêm kết quả xuống file
            using (var sw = new StreamWriter("MyRecord.txt", append: true))
            {
                sw.WriteLine(lblDongHo.Text);
            }
        }
    }
}
