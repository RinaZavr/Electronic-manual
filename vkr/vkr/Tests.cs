using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vkr
{
    public partial class Tests : Form
    {
        private static readonly int[][] tests = {
            new int[] {4, 7, 15, 30, 31, 35}, new int[] {2, 4, 12, 30, 31, 33}, new int[] {2, 4, 9, 31, 33, 34},
            new int[] {2, 8, 9, 29, 31, 35}, new int[] {2, 4, 14, 31, 33, 34}, new int[] {2, 8, 15, 23, 31},
            new int[] {7, 8, 15, 24, 28, 32}, new int[] {4, 13, 15, 23, 31, 32}, new int[] {8, 13, 15, 21, 33, 34},
            new int[] {2, 8, 9, 27, 31}, new int[] {1, 2, 15, 17, 25, 31}, new int[] {7, 8, 15, 31, 33, 34},
            new int[] {2, 8, 9, 20, 24, 30}, new int[] {2, 15, 17, 20, 28, 34}, new int[] {2, 8, 9, 20, 28, 33},
            new int[] {2, 4, 15, 23, 31}, new int[] {2, 8, 9, 21, 33, 34}, new int[] {2, 8, 9, 21, 24, 30},
            new int[] {2, 9, 17, 22, 24, 34}, new int[] {8, 13, 15, 30, 31, 33}, new int[] {4, 7, 19, 23, 31, 36},
            new int[] {4, 7, 19, 23, 24, 36}, new int[] {2, 4, 9, 31, 35}, new int[] {1, 2, 4, 31, 33},
            new int[] {4, 7, 15, 31, 33, 34}, new int[] {16, 17, 19, 31, 34, 35}, new int[] {4, 7, 15, 30, 31, 33},
            new int[] {16, 17, 19, 22, 29, 33}, new int[] {2, 4, 12, 21, 24, 30}, new int[] {15, 16, 17, 31, 35},
            new int[] {4, 7, 19, 26, 32, 33}, new int[] {2, 15, 17, 26, 28, 31}, new int[] {1, 4, 7, 15, 25, 31},
            new int[] {2, 4, 5, 21, 31}, new int[] {2, 15, 17, 30, 31, 35}, new int[] {4, 5, 13, 26, 32, 33},
            new int[] {4, 5, 7, 26, 32, 33}, new int[] {1, 2, 4, 22, 31}, new int[] {2, 4, 15, 31, 33},
            new int[] {2, 4, 15, 24, 31}, new int[] {8, 13, 15, 27, 31}, new int[] {4, 12, 13, 15, 22, 24}, 
            new int[] {4, 13, 19, 26, 32, 33}, new int[] {2, 8, 9, 25, 31, 33}, new int[] {2, 4, 15, 31, 35}, 
            new int[] {5, 8, 12, 16, 22, 24}, new int[] {7, 8, 15, 23, 31, 32}, new int[] {7, 8, 15, 23, 24},
            new int[] {2, 4, 9, 26, 32, 33}, new int[] {15, 16, 17, 26, 32, 33}, new int[] {4, 7, 15, 22, 29, 33},
            new int[] {2, 8, 9, 20, 24, 29}, new int[] {8, 13, 15, 24, 26, 32}, new int[] {2, 4, 9, 25, 31, 33},
            new int[] {2, 15, 17, 25, 31, 35}, new int[] {2, 4, 9, 25, 27, 31}, new int[] {2, 4, 26, 27, 31},
            new int[] {2, 15, 17, 31, 33, 34}, new int[] {1, 2, 4, 22, 34}, new int[] {2, 15, 17, 20, 29, 33},
            new int[] {2, 4, 9, 31, 33}, new int[] {2, 8, 9, 12, 22, 24}, new int[] {2, 4, 15, 27, 31},
            new int[] {1, 2, 4, 22, 26}, new int[] {2, 15, 17, 31, 33}, new int[] {2, 4, 8, 31, 33},
            new int[] {2, 15, 17, 21, 33, 34}, new int[] {4, 13, 15, 24, 31, 32}, new int[] {1, 2, 4, 22, 35},
            new int[] {4, 13, 15, 24, 31}, new int[] {2, 4, 9, 31, 34, 35}, new int[] {2, 15, 17, 23, 31, 36}, 
            new int[] {2, 4, 13, 23, 31, 36}};

        public static int[] TestsRand()
        {
            Random rnd = new Random();
            int ind = rnd.Next(tests.Length);
            return tests[ind];
        }

        private int[] currentTest;
        private int ind = 0;
        private bool isAnswer = false;

        public Tests()
        {
            InitializeComponent();
            currentTest = TestsRand();
            testsAnswers.Visible = false;
            testsPicture.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("_" + String.Join("", currentTest[ind]));
            testsPrevious.Visible = false;
        }

        private void testsClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void testsClose_MouseEnter(object sender, EventArgs e)
        {
            testsClose.ForeColor = Color.Black;
        }

        private void testsClose_MouseLeave(object sender, EventArgs e)
        {
            testsClose.ForeColor = Color.White;
        }

        Point lastPoint;
        private void testsBg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void testsBg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void testsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void testsLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void testsNext_Click(object sender, EventArgs e)
        {
            ind++;
            testsPicture.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("_" + String.Join("", currentTest[ind]));
            if (ind == currentTest.Length - 1)
            {
                testsNext.Visible = false;
                testsAnswers.Visible = true;
            }
            testsPrevious.Visible = true;

            if (isAnswer)
            {
                testsPictureAnswer.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("a" + String.Join("", currentTest[ind]));
                testsAnswers.Visible = false;
            }
        }

        private void testsPrevious_Click(object sender, EventArgs e)
        {
            ind--;
            testsPicture.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("_" + String.Join("", currentTest[ind]));
            if (ind == 0)
            {
                testsPrevious.Visible = false;
            }
            if(ind != currentTest.Length - 1)
            {
                testsAnswers.Visible = false;
            }
            testsNext.Visible = true;
            if (isAnswer)
            {
                testsPictureAnswer.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("a" + String.Join("", currentTest[ind]));
                testsAnswers.Visible = false;
            }
        }

        private void testsAnswers_Click(object sender, EventArgs e)
        {
            ind = 0;
            testsAnswers.Visible = false;
            testsPictureAnswer.BackgroundImage = (Image)manual.Properties.Resources.ResourceManager.GetObject("a" + String.Join("", currentTest[ind]));
            testsPrevious.Visible = false;
            testsNext.Visible = true;
            isAnswer = true;
            testsPictureAnswer.BackColor = Color.White;
        }
    }
}