namespace Lab07QLHS
{
    partial class FrmQLLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CboListType = new ComboBox();
            lvLop = new ListView();
            groupBox1 = new GroupBox();
            txtSiSo = new TextBox();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(48, 96);
            label1.Name = "label1";
            label1.Size = new Size(250, 46);
            label1.TabIndex = 0;
            label1.Text = "Danh sách lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(847, 99);
            label2.Name = "label2";
            label2.Size = new Size(226, 46);
            label2.TabIndex = 1;
            label2.Text = "Kiểu hiển thị";
            // 
            // CboListType
            // 
            CboListType.DropDownStyle = ComboBoxStyle.DropDownList;
            CboListType.Font = new Font("Times New Roman", 12F);
            CboListType.FormattingEnabled = true;
            CboListType.Items.AddRange(new object[] { "Detail", "Large Icon", "List", "Small Icon", "Tile" });
            CboListType.Location = new Point(1096, 96);
            CboListType.Name = "CboListType";
            CboListType.Size = new Size(396, 54);
            CboListType.TabIndex = 2;
            CboListType.SelectedIndexChanged += CboListType_SelectedIndexChanged;
            // 
            // lvLop
            // 
            lvLop.Font = new Font("Times New Roman", 12F);
            lvLop.Location = new Point(48, 179);
            lvLop.Name = "lvLop";
            lvLop.Size = new Size(1444, 474);
            lvLop.TabIndex = 3;
            lvLop.UseCompatibleStateImageBehavior = false;
            lvLop.ItemSelectionChanged += lvLop_ItemSelectionChanged;
            lvLop.SelectedIndexChanged += lvLop_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSiSo);
            groupBox1.Controls.Add(txtTenLop);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(48, 682);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 309);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp";
            // 
            // txtSiSo
            // 
            txtSiSo.Font = new Font("Times New Roman", 12F);
            txtSiSo.Location = new Point(293, 233);
            txtSiSo.Name = "txtSiSo";
            txtSiSo.Size = new Size(466, 53);
            txtSiSo.TabIndex = 3;
            // 
            // txtTenLop
            // 
            txtTenLop.Font = new Font("Times New Roman", 12F);
            txtTenLop.Location = new Point(293, 152);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(466, 53);
            txtTenLop.TabIndex = 2;
            // 
            // txtMaLop
            // 
            txtMaLop.Font = new Font("Times New Roman", 12F);
            txtMaLop.Location = new Point(293, 70);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(466, 53);
            txtMaLop.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(36, 224);
            label5.Name = "label5";
            label5.Size = new Size(98, 46);
            label5.TabIndex = 0;
            label5.Text = "Sỉ số";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(36, 152);
            label4.Name = "label4";
            label4.Size = new Size(143, 46);
            label4.TabIndex = 0;
            label4.Text = "Tên lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(36, 70);
            label3.Name = "label3";
            label3.Size = new Size(136, 46);
            label3.TabIndex = 0;
            label3.Text = "Mã lớp";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.Location = new Point(908, 710);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(242, 105);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.Location = new Point(1215, 710);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(242, 105);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(908, 857);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(242, 105);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F);
            btnThoat.Location = new Point(1215, 857);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(242, 105);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmQLLop
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 1020);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(lvLop);
            Controls.Add(CboListType);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQLLop";
            Text = "QUẢN LÝ LỚP";
            Load += FrmQLLop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CboListType;
        private ListView lvLop;
        private GroupBox groupBox1;
        private TextBox txtSiSo;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
    }
}