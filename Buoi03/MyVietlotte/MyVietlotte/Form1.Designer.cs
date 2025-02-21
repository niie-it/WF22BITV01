namespace MyVietlotte
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
            btnGenerate = new Button();
            txtKetQua = new TextBox();
            rad645 = new RadioButton();
            rad655 = new RadioButton();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(340, 129);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(188, 58);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(41, 230);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(760, 118);
            txtKetQua.TabIndex = 1;
            // 
            // rad645
            // 
            rad645.AutoSize = true;
            rad645.Checked = true;
            rad645.Location = new Point(75, 26);
            rad645.Name = "rad645";
            rad645.Size = new Size(205, 45);
            rad645.TabIndex = 2;
            rad645.TabStop = true;
            rad645.Text = "MEGA 6/45";
            rad645.UseVisualStyleBackColor = true;
            // 
            // rad655
            // 
            rad655.AutoSize = true;
            rad655.Location = new Point(489, 33);
            rad655.Name = "rad655";
            rad655.Size = new Size(223, 45);
            rad655.TabIndex = 3;
            rad655.Text = "POWER 6/55";
            rad655.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rad655);
            Controls.Add(rad645);
            Controls.Add(txtKetQua);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "MUA VIETLOTT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtKetQua;
        private RadioButton rad645;
        private RadioButton rad655;
    }
}
