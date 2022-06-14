
namespace vkr
{
    partial class Tests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tests));
            this.testsBg = new System.Windows.Forms.Panel();
            this.testsPictureAnswer = new System.Windows.Forms.PictureBox();
            this.testsAnswers = new System.Windows.Forms.Button();
            this.testsPrevious = new System.Windows.Forms.Button();
            this.testsPicture = new System.Windows.Forms.PictureBox();
            this.testsNext = new System.Windows.Forms.Button();
            this.testsLabelBg = new System.Windows.Forms.Panel();
            this.testsClose = new System.Windows.Forms.Label();
            this.testsLabel = new System.Windows.Forms.Label();
            this.testsBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsPictureAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsPicture)).BeginInit();
            this.testsLabelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // testsBg
            // 
            this.testsBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("testsBg.BackgroundImage")));
            this.testsBg.Controls.Add(this.testsPictureAnswer);
            this.testsBg.Controls.Add(this.testsAnswers);
            this.testsBg.Controls.Add(this.testsPrevious);
            this.testsBg.Controls.Add(this.testsPicture);
            this.testsBg.Controls.Add(this.testsNext);
            this.testsBg.Controls.Add(this.testsLabelBg);
            this.testsBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsBg.Location = new System.Drawing.Point(0, 0);
            this.testsBg.Name = "testsBg";
            this.testsBg.Size = new System.Drawing.Size(1053, 500);
            this.testsBg.TabIndex = 0;
            this.testsBg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testsBg_MouseDown);
            this.testsBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.testsBg_MouseMove);
            // 
            // testsPictureAnswer
            // 
            this.testsPictureAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsPictureAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.testsPictureAnswer.Location = new System.Drawing.Point(51, 286);
            this.testsPictureAnswer.Name = "testsPictureAnswer";
            this.testsPictureAnswer.Size = new System.Drawing.Size(959, 87);
            this.testsPictureAnswer.TabIndex = 8;
            this.testsPictureAnswer.TabStop = false;
            // 
            // testsAnswers
            // 
            this.testsAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.testsAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsAnswers.FlatAppearance.BorderSize = 0;
            this.testsAnswers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsAnswers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.testsAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsAnswers.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testsAnswers.ForeColor = System.Drawing.Color.White;
            this.testsAnswers.Location = new System.Drawing.Point(441, 406);
            this.testsAnswers.Name = "testsAnswers";
            this.testsAnswers.Size = new System.Drawing.Size(197, 57);
            this.testsAnswers.TabIndex = 7;
            this.testsAnswers.Text = "ОТВЕТЫ";
            this.testsAnswers.UseVisualStyleBackColor = false;
            this.testsAnswers.Click += new System.EventHandler(this.testsAnswers_Click);
            // 
            // testsPrevious
            // 
            this.testsPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.testsPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsPrevious.FlatAppearance.BorderSize = 0;
            this.testsPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.testsPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsPrevious.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testsPrevious.ForeColor = System.Drawing.Color.White;
            this.testsPrevious.Location = new System.Drawing.Point(51, 406);
            this.testsPrevious.Name = "testsPrevious";
            this.testsPrevious.Size = new System.Drawing.Size(197, 57);
            this.testsPrevious.TabIndex = 5;
            this.testsPrevious.Text = "НАЗАД";
            this.testsPrevious.UseVisualStyleBackColor = false;
            this.testsPrevious.Click += new System.EventHandler(this.testsPrevious_Click);
            // 
            // testsPicture
            // 
            this.testsPicture.BackColor = System.Drawing.Color.White;
            this.testsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.testsPicture.Location = new System.Drawing.Point(51, 148);
            this.testsPicture.Name = "testsPicture";
            this.testsPicture.Size = new System.Drawing.Size(959, 112);
            this.testsPicture.TabIndex = 4;
            this.testsPicture.TabStop = false;
            // 
            // testsNext
            // 
            this.testsNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.testsNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsNext.FlatAppearance.BorderSize = 0;
            this.testsNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.testsNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testsNext.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testsNext.ForeColor = System.Drawing.Color.White;
            this.testsNext.Location = new System.Drawing.Point(813, 406);
            this.testsNext.Name = "testsNext";
            this.testsNext.Size = new System.Drawing.Size(197, 57);
            this.testsNext.TabIndex = 3;
            this.testsNext.Text = "ДАЛЕЕ";
            this.testsNext.UseVisualStyleBackColor = false;
            this.testsNext.Click += new System.EventHandler(this.testsNext_Click);
            // 
            // testsLabelBg
            // 
            this.testsLabelBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsLabelBg.Controls.Add(this.testsClose);
            this.testsLabelBg.Controls.Add(this.testsLabel);
            this.testsLabelBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.testsLabelBg.Location = new System.Drawing.Point(0, 0);
            this.testsLabelBg.Name = "testsLabelBg";
            this.testsLabelBg.Size = new System.Drawing.Size(1053, 125);
            this.testsLabelBg.TabIndex = 0;
            this.testsLabelBg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testsLabel_MouseDown);
            this.testsLabelBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.testsLabel_MouseMove);
            // 
            // testsClose
            // 
            this.testsClose.AutoSize = true;
            this.testsClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testsClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testsClose.ForeColor = System.Drawing.Color.White;
            this.testsClose.Location = new System.Drawing.Point(1013, 0);
            this.testsClose.Name = "testsClose";
            this.testsClose.Size = new System.Drawing.Size(36, 41);
            this.testsClose.TabIndex = 1;
            this.testsClose.Text = "X";
            this.testsClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.testsClose.Click += new System.EventHandler(this.testsClose_Click);
            this.testsClose.MouseEnter += new System.EventHandler(this.testsClose_MouseEnter);
            this.testsClose.MouseLeave += new System.EventHandler(this.testsClose_MouseLeave);
            // 
            // testsLabel
            // 
            this.testsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testsLabel.ForeColor = System.Drawing.Color.White;
            this.testsLabel.Location = new System.Drawing.Point(0, 0);
            this.testsLabel.Name = "testsLabel";
            this.testsLabel.Size = new System.Drawing.Size(1053, 125);
            this.testsLabel.TabIndex = 0;
            this.testsLabel.Text = "ДИФФЕРЕНЦИАЛЬНОЕ И ИНТЕГРАЛЬНОЕ ИСЧИСЛЕНИЕ";
            this.testsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1053, 500);
            this.Controls.Add(this.testsBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestsForm";
            this.Text = "TestsForm";
            this.testsBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsPictureAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsPicture)).EndInit();
            this.testsLabelBg.ResumeLayout(false);
            this.testsLabelBg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel testsBg;
        private System.Windows.Forms.Panel testsLabelBg;
        private System.Windows.Forms.Label testsLabel;
        private System.Windows.Forms.Label testsClose;
        private System.Windows.Forms.Button testsNext;
        private System.Windows.Forms.PictureBox testsPicture;
        private System.Windows.Forms.Button testsPrevious;
        private System.Windows.Forms.Button testsAnswers;
        private System.Windows.Forms.PictureBox testsPictureAnswer;
    }
}