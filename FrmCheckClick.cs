using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4
{
    public partial class FrmCheckClick : Form
    {
        public FrmCheckClick()
        {
            InitializeComponent();
        }

        private Rectangle rect;

        private void FrmCheckClick_Load(object sender, EventArgs e)
        {
            DrawRect();
        }

        private void DrawRect()
        {
            Random rand = new Random();
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int rectWidth = rand.Next(50, formWidth / 2);
            int rectHeight = rand.Next(50, formHeight / 2);
            int rectX = rand.Next(0, formWidth - rectWidth);
            int rectY = rand.Next(0, formHeight - rectHeight);

            rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = CreateGraphics())
            {
                g.Clear(this.BackColor);
                e.Graphics.DrawRectangle(Pens.Black, rect);
            }
        }

        private void FrmCheckClick_MouseClick(object sender, MouseEventArgs e)
        {
            if (rect.Contains(e.X, e.Y))            
                this.Text = $"Попал ({e.X}, {e.Y})";            
            else            
                this.Text = $"Не попал ({e.X}, {e.Y})";
            
            DrawRect();
        }


    }
}
