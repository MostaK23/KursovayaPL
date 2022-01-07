using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MathGraphics.Services.Services;
using MathGraphics.Data.Repositories;

namespace MathGraphics
{
    public partial class MainWindow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public MainWindow()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            lblTitle.Text = "Home";

            this.pnlFormLoader.Controls.Clear();
            frmHome FrmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTasks.Height;
            pnlNav.Top = btnTasks.Top;
            btnTasks.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Tasks";

            this.pnlFormLoader.Controls.Clear();
            TasksForm FrmTasks_Vrb = new TasksForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            FrmTasks_Vrb.FormBorderStyle = FormBorderStyle.None;

            this.pnlFormLoader.Controls.Add(FrmTasks_Vrb);
            FrmTasks_Vrb.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTheory.Height;
            pnlNav.Top = btnTheory.Top;
            btnTheory.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Notes";

            this.pnlFormLoader.Controls.Clear();
            FrmNote FrmTheory_Vrb = new FrmNote(new NoteService(new JsonRepository(Config.DatabaseNameJson)))
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            FrmTheory_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmTheory_Vrb);
            FrmTheory_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";

            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmSettings_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            FrmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSettings_Vrb);
            FrmSettings_Vrb.Show();
        }

        private void btnTasks_Leave(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNote_Leave(object sender, EventArgs e)
        {
            btnTheory.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
