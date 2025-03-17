namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable
        Color borderColor = Color.Black;
        Color fillColor = Color.Green;
        Point startPoint;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBorderColor.BackColor = borderColor;
            btnFillColor.BackColor = fillColor;
            cboType.SelectedIndex = 0;
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                borderColor = cd.Color;
                btnBorderColor.BackColor = borderColor;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.FullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fillColor = cd.Color;
                btnFillColor.BackColor = fillColor;
            }
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            var g = splitContainer1.Panel2.CreateGraphics();

            var pen = new Pen(borderColor, float.Parse(nudBorderSize.Value.ToString()));
            var x = Math.Min(startPoint.X, e.X);
            var y = Math.Min(startPoint.Y, e.Y);
            var w = Math.Abs(startPoint.X - e.X);
            var h = Math.Abs(startPoint.Y - e.Y);
            var brush = new SolidBrush(fillColor);

            switch (cboType.SelectedIndex)
            {
                case 0: //Draw Line
                    g.DrawLine(pen, startPoint, e.Location);
                    break;
                case 1: // Draw Rectangle
                    g.DrawRectangle(pen, x, y, w, h);
                    break;
                case 2: // Draw Ellipse
                    g.DrawEllipse(pen, x, y, w, h);
                    break;
                case 3: // Fill Rectangle
                    g.FillRectangle(brush, x, y, w, h);
                    break;
                case 4: // Fill Ellipse
                    g.FillEllipse(brush, x, y, w, h);
                    break;
            }
        }
    }
}
