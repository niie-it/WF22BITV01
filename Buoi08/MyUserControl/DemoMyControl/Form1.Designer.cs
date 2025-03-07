namespace DemoMyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucDongHo1 = new MyControl.UCDongHo();
            this.ucDongHo2 = new MyControl.UCDongHo();
            this.SuspendLayout();
            // 
            // ucDongHo1
            // 
            this.ucDongHo1.Location = new System.Drawing.Point(12, 3);
            this.ucDongHo1.Name = "ucDongHo1";
            this.ucDongHo1.Size = new System.Drawing.Size(597, 288);
            this.ucDongHo1.TabIndex = 0;
            // 
            // ucDongHo2
            // 
            this.ucDongHo2.Location = new System.Drawing.Point(12, 280);
            this.ucDongHo2.Name = "ucDongHo2";
            this.ucDongHo2.Size = new System.Drawing.Size(597, 288);
            this.ucDongHo2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 580);
            this.Controls.Add(this.ucDongHo2);
            this.Controls.Add(this.ucDongHo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl.UCDongHo ucDongHo1;
        private MyControl.UCDongHo ucDongHo2;
    }
}

