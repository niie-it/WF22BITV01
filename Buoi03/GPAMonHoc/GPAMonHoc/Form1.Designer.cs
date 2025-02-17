namespace GPAMonHoc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuyenCan = new System.Windows.Forms.TextBox();
            this.txtThucHanh = new System.Windows.Forms.TextBox();
            this.txtDoAn = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên cần (20%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thực hành (20%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đồ án (60%)";
            // 
            // txtChuyenCan
            // 
            this.txtChuyenCan.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenCan.Location = new System.Drawing.Point(384, 28);
            this.txtChuyenCan.Name = "txtChuyenCan";
            this.txtChuyenCan.Size = new System.Drawing.Size(269, 52);
            this.txtChuyenCan.TabIndex = 3;
            // 
            // txtThucHanh
            // 
            this.txtThucHanh.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThucHanh.Location = new System.Drawing.Point(384, 104);
            this.txtThucHanh.Name = "txtThucHanh";
            this.txtThucHanh.Size = new System.Drawing.Size(269, 52);
            this.txtThucHanh.TabIndex = 4;
            // 
            // txtDoAn
            // 
            this.txtDoAn.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoAn.Location = new System.Drawing.Point(384, 181);
            this.txtDoAn.Name = "txtDoAn";
            this.txtDoAn.Size = new System.Drawing.Size(269, 52);
            this.txtDoAn.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(384, 256);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(241, 78);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(43, 364);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(712, 300);
            this.txtKetQua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDoAn);
            this.Controls.Add(this.txtThucHanh);
            this.Controls.Add(this.txtChuyenCan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính điểm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuyenCan;
        private System.Windows.Forms.TextBox txtThucHanh;
        private System.Windows.Forms.TextBox txtDoAn;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

