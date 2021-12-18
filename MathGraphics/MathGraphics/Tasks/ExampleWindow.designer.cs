namespace MathGraphics
{
    partial class ExampleWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Y0TextBox = new System.Windows.Forms.TextBox();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.DeltaTextBox = new System.Windows.Forms.TextBox();
            this.X0TextBox = new System.Windows.Forms.TextBox();
            this.DrawButton = new MathGraphics.RoundButton();
            this.CheckButton = new MathGraphics.RoundButton();
            this.lblYo = new System.Windows.Forms.Label();
            this.lblEpsilon = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblXo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Label();
            this.GraphicCollection = new System.Windows.Forms.ComboBox();
            this.DrawSelectedGraphicButton = new MathGraphics.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.Y0TextBox);
            this.panel1.Controls.Add(this.EpsilonTextBox);
            this.panel1.Controls.Add(this.DeltaTextBox);
            this.panel1.Controls.Add(this.X0TextBox);
            this.panel1.Controls.Add(this.DrawButton);
            this.panel1.Controls.Add(this.CheckButton);
            this.panel1.Controls.Add(this.lblYo);
            this.panel1.Controls.Add(this.lblEpsilon);
            this.panel1.Controls.Add(this.lblDelta);
            this.panel1.Controls.Add(this.lblXo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 139);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Y0TextBox
            // 
            this.Y0TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Y0TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Y0TextBox.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y0TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Y0TextBox.Location = new System.Drawing.Point(569, 85);
            this.Y0TextBox.Multiline = true;
            this.Y0TextBox.Name = "Y0TextBox";
            this.Y0TextBox.ReadOnly = true;
            this.Y0TextBox.Size = new System.Drawing.Size(172, 25);
            this.Y0TextBox.TabIndex = 14;
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.EpsilonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpsilonTextBox.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EpsilonTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EpsilonTextBox.Location = new System.Drawing.Point(108, 99);
            this.EpsilonTextBox.Multiline = true;
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(172, 25);
            this.EpsilonTextBox.TabIndex = 13;
            // 
            // DeltaTextBox
            // 
            this.DeltaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.DeltaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeltaTextBox.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeltaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DeltaTextBox.Location = new System.Drawing.Point(108, 62);
            this.DeltaTextBox.Multiline = true;
            this.DeltaTextBox.Name = "DeltaTextBox";
            this.DeltaTextBox.Size = new System.Drawing.Size(172, 25);
            this.DeltaTextBox.TabIndex = 12;
            // 
            // X0TextBox
            // 
            this.X0TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.X0TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.X0TextBox.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.X0TextBox.Location = new System.Drawing.Point(108, 22);
            this.X0TextBox.Multiline = true;
            this.X0TextBox.Name = "X0TextBox";
            this.X0TextBox.Size = new System.Drawing.Size(172, 25);
            this.X0TextBox.TabIndex = 11;
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DrawButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DrawButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.DrawButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.DrawButton.ButtonRoundRadius = 30;
            this.DrawButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Location = new System.Drawing.Point(344, 18);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(175, 53);
            this.DrawButton.TabIndex = 9;
            this.DrawButton.Text = "Draw";
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.CheckButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.CheckButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.CheckButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CheckButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.CheckButton.ButtonRoundRadius = 30;
            this.CheckButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.Location = new System.Drawing.Point(344, 71);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(175, 53);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check";
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYo.ForeColor = System.Drawing.Color.White;
            this.lblYo.Location = new System.Drawing.Point(527, 85);
            this.lblYo.Name = "lblYo";
            this.lblYo.Size = new System.Drawing.Size(37, 25);
            this.lblYo.TabIndex = 7;
            this.lblYo.Text = "Y0:";
            // 
            // lblEpsilon
            // 
            this.lblEpsilon.AutoSize = true;
            this.lblEpsilon.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpsilon.ForeColor = System.Drawing.Color.White;
            this.lblEpsilon.Location = new System.Drawing.Point(28, 99);
            this.lblEpsilon.Name = "lblEpsilon";
            this.lblEpsilon.Size = new System.Drawing.Size(77, 25);
            this.lblEpsilon.TabIndex = 3;
            this.lblEpsilon.Text = "Epsilon:";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.ForeColor = System.Drawing.Color.White;
            this.lblDelta.Location = new System.Drawing.Point(28, 58);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(60, 25);
            this.lblDelta.TabIndex = 2;
            this.lblDelta.Text = "Delta:";
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXo.ForeColor = System.Drawing.Color.White;
            this.lblXo.Location = new System.Drawing.Point(28, 18);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(37, 25);
            this.lblXo.TabIndex = 1;
            this.lblXo.Text = "X0:";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(963, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Instruction
            // 
            this.Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instruction.ForeColor = System.Drawing.SystemColors.Control;
            this.Instruction.Location = new System.Drawing.Point(802, 302);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(198, 196);
            this.Instruction.TabIndex = 13;
            // 
            // GraphicCollection
            // 
            this.GraphicCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GraphicCollection.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.GraphicCollection.ForeColor = System.Drawing.Color.White;
            this.GraphicCollection.FormattingEnabled = true;
            this.GraphicCollection.Items.AddRange(new object[] {
            "Parabola",
            "Cos",
            "Sin",
            "Cubical"});
            this.GraphicCollection.Location = new System.Drawing.Point(802, 69);
            this.GraphicCollection.Name = "GraphicCollection";
            this.GraphicCollection.Size = new System.Drawing.Size(186, 33);
            this.GraphicCollection.TabIndex = 14;
            this.GraphicCollection.Text = "Parabola";
            // 
            // DrawSelectedGraphicButton
            // 
            this.DrawSelectedGraphicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawSelectedGraphicButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawSelectedGraphicButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawSelectedGraphicButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DrawSelectedGraphicButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DrawSelectedGraphicButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.DrawSelectedGraphicButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawSelectedGraphicButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DrawSelectedGraphicButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.DrawSelectedGraphicButton.ButtonRoundRadius = 30;
            this.DrawSelectedGraphicButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawSelectedGraphicButton.ForeColor = System.Drawing.Color.White;
            this.DrawSelectedGraphicButton.Location = new System.Drawing.Point(802, 108);
            this.DrawSelectedGraphicButton.Name = "DrawSelectedGraphicButton";
            this.DrawSelectedGraphicButton.Size = new System.Drawing.Size(186, 50);
            this.DrawSelectedGraphicButton.TabIndex = 15;
            this.DrawSelectedGraphicButton.Text = "Draw";
            this.DrawSelectedGraphicButton.Click += new System.EventHandler(this.DrawSelectedGraphicButton_Click);
            // 
            // ExampleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.DrawSelectedGraphicButton);
            this.Controls.Add(this.GraphicCollection);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExampleWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ExampleWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEpsilon;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.Button btnExit;
        private RoundButton CheckButton;
        private System.Windows.Forms.Label lblYo;
        private RoundButton DrawButton;
        private System.Windows.Forms.TextBox Y0TextBox;
        private System.Windows.Forms.TextBox EpsilonTextBox;
        private System.Windows.Forms.TextBox DeltaTextBox;
        private System.Windows.Forms.TextBox X0TextBox;
        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.ComboBox GraphicCollection;
        private RoundButton DrawSelectedGraphicButton;
    }
}

