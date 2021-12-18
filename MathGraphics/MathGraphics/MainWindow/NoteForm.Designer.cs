
namespace MathGraphics
{
    partial class FrmNote
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.DeleteIdInput = new System.Windows.Forms.TextBox();
            this.DeleteButton = new MathGraphics.RoundButton();
            this.UpdateButton = new MathGraphics.RoundButton();
            this.AddButton = new MathGraphics.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.InputBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox.ForeColor = System.Drawing.Color.White;
            this.InputBox.Location = new System.Drawing.Point(16, 43);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(302, 85);
            this.InputBox.TabIndex = 34;
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.OutputBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBox.ForeColor = System.Drawing.Color.White;
            this.OutputBox.Location = new System.Drawing.Point(420, 43);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(302, 347);
            this.OutputBox.TabIndex = 35;
            // 
            // DeleteIdInput
            // 
            this.DeleteIdInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.DeleteIdInput.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteIdInput.ForeColor = System.Drawing.Color.White;
            this.DeleteIdInput.Location = new System.Drawing.Point(12, 365);
            this.DeleteIdInput.Name = "DeleteIdInput";
            this.DeleteIdInput.Size = new System.Drawing.Size(175, 25);
            this.DeleteIdInput.TabIndex = 37;
            this.DeleteIdInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableLetters);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DeleteButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.DeleteButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeleteButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.DeleteButton.ButtonRoundRadius = 30;
            this.DeleteButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(12, 396);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 53);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.UpdateButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.UpdateButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.UpdateButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UpdateButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.UpdateButton.ButtonRoundRadius = 30;
            this.UpdateButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(484, 396);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(175, 53);
            this.UpdateButton.TabIndex = 36;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.AddButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.AddButton.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.AddButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddButton.ButtonPressedForeColor = System.Drawing.Color.Silver;
            this.AddButton.ButtonRoundRadius = 30;
            this.AddButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(80, 134);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 53);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Enter note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(417, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Note list";
            // 
            // FrmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteIdInput);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNote";
            this.Text = "frmTheory";
            this.Load += new System.EventHandler(this.frmTheory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton AddButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private RoundButton UpdateButton;
        private System.Windows.Forms.TextBox DeleteIdInput;
        private RoundButton DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}