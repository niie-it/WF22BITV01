namespace HelloFriend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblThongBao = new Label();
            txtHoTen = new TextBox();
            btnXuLy = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            label1.Click += label1_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(27, 121);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(163, 41);
            lblThongBao.TabIndex = 1;
            lblThongBao.Text = "Thông báo";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(200, 46);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(310, 47);
            txtHoTen.TabIndex = 2;
            // 
            // btnXuLy
            // 
            btnXuLy.Location = new Point(574, 40);
            btnXuLy.Name = "btnXuLy";
            btnXuLy.Size = new Size(188, 58);
            btnXuLy.TabIndex = 3;
            btnXuLy.Text = "Xử lý";
            btnXuLy.UseVisualStyleBackColor = true;
            btnXuLy.Click += btnXuLy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(574, 140);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(188, 58);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += XuLyThoat;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 210);
            Controls.Add(btnThoat);
            Controls.Add(btnXuLy);
            Controls.Add(txtHoTen);
            Controls.Add(lblThongBao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblThongBao;
        private TextBox txtHoTen;
        private Button btnXuLy;
        private Button btnThoat;
    }
}
