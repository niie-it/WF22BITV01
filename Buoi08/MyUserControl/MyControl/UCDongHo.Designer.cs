namespace MyControl
{
    partial class UCDongHo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(22, 188);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(261, 76);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnLap
            // 
            this.btnLap.Enabled = false;
            this.btnLap.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLap.Location = new System.Drawing.Point(310, 188);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(261, 76);
            this.btnLap.TabIndex = 0;
            this.btnLap.Text = "LAP";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblDongHo.ForeColor = System.Drawing.Color.Blue;
            this.lblDongHo.Location = new System.Drawing.Point(100, 61);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(388, 72);
            this.lblDongHo.TabIndex = 1;
            this.lblDongHo.Text = "00:00:00 000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStartStop);
            this.Name = "UCDongHo";
            this.Size = new System.Drawing.Size(597, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Timer timer1;
    }
}
