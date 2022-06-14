
namespace vkr
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainBg = new System.Windows.Forms.Panel();
            this.mainInfo = new System.Windows.Forms.Button();
            this.mainTests = new System.Windows.Forms.Button();
            this.mainOpenManual = new System.Windows.Forms.Button();
            this.mainBgLabel = new System.Windows.Forms.Panel();
            this.mainCLose = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainBg.SuspendLayout();
            this.mainBgLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBg
            // 
            this.mainBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBg.BackgroundImage")));
            this.mainBg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainBg.Controls.Add(this.mainInfo);
            this.mainBg.Controls.Add(this.mainTests);
            this.mainBg.Controls.Add(this.mainOpenManual);
            this.mainBg.Controls.Add(this.mainBgLabel);
            this.mainBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBg.Location = new System.Drawing.Point(0, 0);
            this.mainBg.Name = "mainBg";
            this.mainBg.Size = new System.Drawing.Size(1053, 541);
            this.mainBg.TabIndex = 0;
            this.mainBg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainBg_MouseDown);
            this.mainBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainBg_MouseMove);
            // 
            // mainInfo
            // 
            this.mainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.mainInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainInfo.FlatAppearance.BorderSize = 0;
            this.mainInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainInfo.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.mainInfo.Location = new System.Drawing.Point(298, 389);
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Size = new System.Drawing.Size(441, 89);
            this.mainInfo.TabIndex = 5;
            this.mainInfo.Text = "ИНСТРУКЦИЯ";
            this.mainInfo.UseVisualStyleBackColor = false;
            this.mainInfo.Click += new System.EventHandler(this.mainInfo_Click);
            // 
            // mainTests
            // 
            this.mainTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.mainTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainTests.FlatAppearance.BorderSize = 0;
            this.mainTests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainTests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTests.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainTests.ForeColor = System.Drawing.SystemColors.Window;
            this.mainTests.Location = new System.Drawing.Point(298, 278);
            this.mainTests.Name = "mainTests";
            this.mainTests.Size = new System.Drawing.Size(441, 89);
            this.mainTests.TabIndex = 4;
            this.mainTests.Text = "ТЕСТЫ";
            this.mainTests.UseVisualStyleBackColor = false;
            this.mainTests.Click += new System.EventHandler(this.mainTests_Click);
            // 
            // mainOpenManual
            // 
            this.mainOpenManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(230)))));
            this.mainOpenManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainOpenManual.FlatAppearance.BorderSize = 0;
            this.mainOpenManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainOpenManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainOpenManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainOpenManual.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainOpenManual.ForeColor = System.Drawing.SystemColors.Window;
            this.mainOpenManual.Location = new System.Drawing.Point(298, 165);
            this.mainOpenManual.Name = "mainOpenManual";
            this.mainOpenManual.Size = new System.Drawing.Size(441, 89);
            this.mainOpenManual.TabIndex = 3;
            this.mainOpenManual.Text = "ЭЛЕКТРОННОЕ ПОСОБИЕ";
            this.mainOpenManual.UseVisualStyleBackColor = false;
            this.mainOpenManual.Click += new System.EventHandler(this.mainOpenManual_Click);
            // 
            // mainBgLabel
            // 
            this.mainBgLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBgLabel.Controls.Add(this.mainCLose);
            this.mainBgLabel.Controls.Add(this.mainLabel);
            this.mainBgLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBgLabel.ForeColor = System.Drawing.Color.Black;
            this.mainBgLabel.Location = new System.Drawing.Point(0, 0);
            this.mainBgLabel.Name = "mainBgLabel";
            this.mainBgLabel.Size = new System.Drawing.Size(1049, 125);
            this.mainBgLabel.TabIndex = 0;
            // 
            // mainCLose
            // 
            this.mainCLose.AutoSize = true;
            this.mainCLose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainCLose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainCLose.ForeColor = System.Drawing.Color.White;
            this.mainCLose.Location = new System.Drawing.Point(1013, 0);
            this.mainCLose.Name = "mainCLose";
            this.mainCLose.Size = new System.Drawing.Size(36, 41);
            this.mainCLose.TabIndex = 1;
            this.mainCLose.Text = "X";
            this.mainCLose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mainCLose.Click += new System.EventHandler(this.mainCLose_Click);
            this.mainCLose.MouseEnter += new System.EventHandler(this.mainCLose_MouseEnter);
            this.mainCLose.MouseLeave += new System.EventHandler(this.mainCLose_MouseLeave);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(0, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(1049, 125);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "ДИФФЕРЕНЦИАЛЬНОЕ И ИНТЕГРАЛЬНОЕ ИСЧИСЛЕНИЕ";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainLabel_MouseDown);
            this.mainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainLabel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 541);
            this.Controls.Add(this.mainBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainBg.ResumeLayout(false);
            this.mainBgLabel.ResumeLayout(false);
            this.mainBgLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainBg;
        private System.Windows.Forms.Panel mainBgLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label mainCLose;
        private System.Windows.Forms.Button mainOpenManual;
        private System.Windows.Forms.Button mainTests;
        private System.Windows.Forms.Button mainInfo;
    }
}