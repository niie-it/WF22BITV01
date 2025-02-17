namespace WFGiaiPTBac02
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "A.X^2 + B.X + C = 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(210, 184);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(217, 56);
            this.txtA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(210, 251);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(217, 56);
            this.txtB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "C";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(210, 326);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(217, 56);
            this.txtC.TabIndex = 3;
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(605, 166);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(189, 97);
            this.btnGiai.TabIndex = 4;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(605, 296);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(189, 97);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(44, 474);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(928, 210);
            this.txtKetQua.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 714);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

