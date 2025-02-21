namespace DemoSinhVien
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaSV = new TextBox();
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtGPA = new TextBox();
            txtXepLoai = new TextBox();
            btnThem = new Button();
            t = new Button();
            btnXoa = new Button();
            btnXoaHet = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.1F);
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 45);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.1F);
            label2.Location = new Point(55, 128);
            label2.Name = "label2";
            label2.Size = new Size(186, 45);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.1F);
            label3.Location = new Point(55, 212);
            label3.Name = "label3";
            label3.Size = new Size(129, 45);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.1F);
            label4.Location = new Point(695, 128);
            label4.Name = "label4";
            label4.Size = new Size(147, 45);
            label4.TabIndex = 3;
            label4.Text = "Xếp loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.1F);
            label5.Location = new Point(695, 31);
            label5.Name = "label5";
            label5.Size = new Size(87, 45);
            label5.TabIndex = 4;
            label5.Text = "GPA";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Tahoma", 11.1F);
            txtMaSV.Location = new Point(309, 28);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(250, 52);
            txtMaSV.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Tahoma", 11.1F);
            txtDienThoai.Location = new Point(309, 122);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(250, 52);
            txtDienThoai.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Tahoma", 11.1F);
            txtHoTen.Location = new Point(309, 224);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(876, 52);
            txtHoTen.TabIndex = 7;
            // 
            // txtGPA
            // 
            txtGPA.Font = new Font("Tahoma", 11.1F);
            txtGPA.Location = new Point(935, 32);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(250, 52);
            txtGPA.TabIndex = 8;
            // 
            // txtXepLoai
            // 
            txtXepLoai.Font = new Font("Tahoma", 11.1F);
            txtXepLoai.Location = new Point(935, 139);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.ReadOnly = true;
            txtXepLoai.Size = new Size(250, 52);
            txtXepLoai.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Tahoma", 11.1F);
            btnThem.Location = new Point(110, 329);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(243, 119);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // t
            // 
            t.Font = new Font("Tahoma", 11.1F);
            t.Location = new Point(399, 329);
            t.Name = "t";
            t.Size = new Size(243, 119);
            t.TabIndex = 10;
            t.Text = "Sửa";
            t.UseVisualStyleBackColor = true;
            t.Click += t_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Tahoma", 11.1F);
            btnXoa.Location = new Point(711, 329);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(243, 119);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Font = new Font("Tahoma", 11.1F);
            btnXoaHet.Location = new Point(1007, 329);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(243, 119);
            btnXoaHet.TabIndex = 10;
            btnXoaHet.Text = "Xóa hết";
            btnXoaHet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 469);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1260, 431);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 912);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoaHet);
            Controls.Add(btnXoa);
            Controls.Add(t);
            Controls.Add(btnThem);
            Controls.Add(txtXepLoai);
            Controls.Add(txtGPA);
            Controls.Add(txtHoTen);
            Controls.Add(txtDienThoai);
            Controls.Add(txtMaSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSV;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private TextBox txtGPA;
        private TextBox txtXepLoai;
        private Button btnThem;
        private Button t;
        private Button btnXoa;
        private Button btnXoaHet;
        private DataGridView dataGridView1;
    }
}
