using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMyWordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Văn bản|*.txt|My Word|*.rtf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).ToLower() == "*.rtf")
                {
                    rtbDoc.SaveFile(dlg.FileName);
                }
                else
                {
                    File.WriteAllText(dlg.FileName, rtbDoc.Text);
                }
            }
        }
    }
}
