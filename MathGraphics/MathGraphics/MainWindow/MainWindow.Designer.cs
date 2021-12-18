
namespace MathGraphics
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbKuleshovTechnology = new System.Windows.Forms.Label();
            this.programName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnTheory);
            this.panel1.Controls.Add(this.btnTasks);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 580);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(-7, 156);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 67);
            this.pnlNav.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 540);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 40);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnTheory
            // 
            this.btnTheory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheory.FlatAppearance.BorderSize = 0;
            this.btnTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheory.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTheory.Image = ((System.Drawing.Image)(resources.GetObject("btnTheory.Image")));
            this.btnTheory.Location = new System.Drawing.Point(0, 190);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(200, 40);
            this.btnTheory.TabIndex = 5;
            this.btnTheory.Text = "Notes";
            this.btnTheory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnNotes_Click);
            this.btnTheory.Leave += new System.EventHandler(this.btnNote_Leave);
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.Location = new System.Drawing.Point(0, 150);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(200, 40);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            this.btnTasks.Leave += new System.EventHandler(this.btnTasks_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbKuleshovTechnology);
            this.panel2.Controls.Add(this.programName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 0;
            // 
            // lbKuleshovTechnology
            // 
            this.lbKuleshovTechnology.AutoSize = true;
            this.lbKuleshovTechnology.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKuleshovTechnology.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbKuleshovTechnology.Location = new System.Drawing.Point(33, 124);
            this.lbKuleshovTechnology.Name = "lbKuleshovTechnology";
            this.lbKuleshovTechnology.Size = new System.Drawing.Size(139, 17);
            this.lbKuleshovTechnology.TabIndex = 2;
            this.lbKuleshovTechnology.Text = "Kuleshov Technology";
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.programName.Location = new System.Drawing.Point(44, 95);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(113, 18);
            this.programName.TabIndex = 1;
            this.programName.Text = "MathGraphics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(578, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search...";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(891, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(200, 80);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(750, 500);
            this.pnlFormLoader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(220, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Graphics";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbKuleshovTechnology;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
    }
}

