using System;
using System.Drawing;
using OxyPlot.Series;

namespace MathGraphics.Tasks
{
    public partial class Task2 : BaseForm
    {
        public Task2()
        {
            InitializeComponent();

            Instruction.Text = TextResources.SecondTaskInstruction;

            this.Size = new Size(1000, 640);
            this.plotView.Size = plotsSize;
            this.plotView.Location = plotLocation;

            plotView.BackColor = ColorResources.PlotViewBackgroundColor;

            this.deltaTextBox = DeltaTextBox;
            this.epsilonTextBox = EpsilonTextBox;
            this.x0TextBox = X0TextBox;

            int maxLength = 5;

            this.deltaTextBox.MaxLength = maxLength;
            this.deltaTextBox.Text = "1";
            this.epsilonTextBox.MaxLength = maxLength;
            this.epsilonTextBox.Text = "1";
            this.x0TextBox.Text = "3";
            this.x0TextBox.ReadOnly = true;

            plotView.KeyDown += ChangeDelta;
            plotView.KeyDown += ChangeEpsilon;
            plotView.KeyDown += CheckOnButton;
            plotView.KeyDown += DrawOnButton;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            this.Controls.Add(plotView);

            DrawGraphic(UserGraphics.GetExpGraphic(0, 5, step));

            ExtraDrawAction += () =>
            {
                Y0TextBox.Text = GetY0(x0).ToString();
            };

            Draw();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
