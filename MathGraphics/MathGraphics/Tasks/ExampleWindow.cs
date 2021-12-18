using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathGraphics
{
    public partial class ExampleWindow : BaseForm
    {
        public ExampleWindow()
        {
            InitializeComponent();

            Instruction.Text = TextResources.ExampleWindowInstruction;

            this.Size = new Size(1000, 640);
            this.plotView.Size = plotsSize;
            this.plotView.Location = plotLocation;

            plotView.BackColor = ColorResources.PlotViewBackgroundColor;

            this.deltaTextBox = DeltaTextBox;
            this.epsilonTextBox = EpsilonTextBox;
            this.x0TextBox = X0TextBox;

            int maxLength = 5;

            deltaTextBox.MaxLength = maxLength;
            epsilonTextBox.MaxLength = maxLength;
            x0TextBox.MaxLength = maxLength;

            plotView.KeyDown += ChangeDelta;
            plotView.KeyDown += ChangeEpsilon;
            plotView.KeyDown += MoveZeroX;
            plotView.KeyDown += DrawOnButton;
            plotView.KeyDown += CheckOnButton;

            GraphicCollection.SelectedIndexChanged += (s, e) =>
            {
                DrawSelectedGraphic(GraphicCollection.SelectedIndex);
            };
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExampleWindow_Load(object sender, EventArgs e)
        {
            this.Controls.Add(plotView);

            DrawSelectedGraphic(GraphicCollection.SelectedIndex);

            ExtraDrawAction += () =>
            {
                Y0TextBox.Text = GetY0(x0).ToString();
            };
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void DrawSelectedGraphicButton_Click(object sender, EventArgs e)
        {
            DrawSelectedGraphic(GraphicCollection.SelectedIndex);
            Y0TextBox.Text = string.Empty;
        }
    }
}
