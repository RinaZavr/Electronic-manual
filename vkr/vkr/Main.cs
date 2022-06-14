using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace vkr
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mainCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainCLose_MouseEnter(object sender, EventArgs e)
        {
            mainCLose.ForeColor = Color.Black;
        }

        private void mainCLose_MouseLeave(object sender, EventArgs e)
        {
            mainCLose.ForeColor = Color.White;
        }

        Point lastPoint;
        private void mainBg_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainBg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void openUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void mainOpenManual_Click(object sender, EventArgs e)
        {
            openUrl("manual/index.html");
        }

        private void mainTests_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tests tests = new Tests();
            tests.ShowDialog();
            this.Close();
        }

        private void mainInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
            this.Close();
        }
    }
}
