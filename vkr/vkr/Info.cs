using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vkr
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void infoCLose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void infoClose_MouseEnter(object sender, EventArgs e)
        {
            infoClose.ForeColor = Color.Black;
        }

        private void infoCLose_MouseLeave(object sender, EventArgs e)
        {
            infoClose.ForeColor = Color.White;
        }

        Point lastPoint;
        private void infoBg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void infoBg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void infoLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void infoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
