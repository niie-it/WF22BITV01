using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT02
{
    public partial class frmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        const int H = 150; //rộng/cao button
        const int S = 20; //khoảng cách giữa các button cũng như lề

        public frmXuat(int soDong = 1, int soCot = 1)
        {
            InitializeComponent();
            SoDong = soDong;
            SoCot = soCot;

            //Khởi tạo các Button và gắn vào form
            Button button;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    button = new Button
                    {
                        Width = H,
                        Height = H,
                        Left = S + (H + S) * j,
                        Top = S + (H + S) * i,
                        Text = $"{i}, {j}"
                    };
                    button.Click += XuLyButtonClick;
                    this.Controls.Add(button);
                }
            }
            this.Size = new Size
            {
                Width = 3*S + (S + H) * SoCot,
                Height = 4*S + (S + H) * SoDong,
            };
        }


        private void XuLyButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Bạn vừa click button {btn.Text}");
        }
    }
}
