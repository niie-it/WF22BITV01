namespace DemoUC
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
            ucLogin1 = new MyLoginLib.UCLogin();
            ucLogin2 = new MyLoginLib.UCLogin();
            SuspendLayout();
            // 
            // ucLogin1
            // 
            ucLogin1.Location = new Point(12, 12);
            ucLogin1.Name = "ucLogin1";
            ucLogin1.Password = "";
            ucLogin1.Size = new Size(515, 160);
            ucLogin1.TabIndex = 0;
            ucLogin1.UserName = "";
            // 
            // ucLogin2
            // 
            ucLogin2.Location = new Point(12, 204);
            ucLogin2.Name = "ucLogin2";
            ucLogin2.Password = "";
            ucLogin2.Size = new Size(515, 160);
            ucLogin2.TabIndex = 1;
            ucLogin2.UserName = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucLogin2);
            Controls.Add(ucLogin1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyLoginLib.UCLogin ucLogin1;
        private MyLoginLib.UCLogin ucLogin2;
    }
}
