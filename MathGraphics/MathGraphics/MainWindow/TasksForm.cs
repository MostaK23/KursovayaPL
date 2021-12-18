using System;
using MathGraphics.Tasks;
using System.Windows.Forms;

namespace MathGraphics
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var task = new ExampleWindow();

            task.FormClosed += (s, ev) =>
            {
                this.Show();
            };

            task.Show();
        }

        private void Task2_Button_Click(object sender, EventArgs e)
        {
            var task = new Task2();

            task.Show();
        }
    }
}
