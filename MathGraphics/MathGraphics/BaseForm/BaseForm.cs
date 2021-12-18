using OxyPlot;
using OxyPlot.WindowsForms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Класс BaseForm
/// 
/// В конструкторе производного класса необходимо прописать
/// следующие конструкции:
/// 
///     // Размер формы
///     this.Size = formsSize; 
///     // Размер рабочей области графика
///     this.plotView.Size = plotsSize;
///     // Расположение рабочей области графика на форме
///     this.plotView.Location = plotLocation;
///     
/// Для работы, также требуется создать на форме:
///     3 TextBox
///     2 Button
/// 
/// Названия для TextBox:
///     DeltaTextBox
///     EpsilonTextBox
///     ZeroXTextBox
/// 
/// Название для Button:
///     CheckButton
///     DrawButton
/// 
/// 
/// После создания выше перечисленного, необходимо присвоить
/// соответствующие TextBox для каждого поля из класса
/// 
/// <param name="deltaTextBox">DeltaTextBox</param>
/// <param name="epsilonTextBox">EpsilonTextBox</param>
/// <param name="zeroXTextBox">ZeroXTextBox</param>
/// 
/// Желательно установить ограничения вводимых символов в TextBox:
/// 
///     int maxLength = 5;
///     deltaTextBox.MaxLength = maxLength;
///     epsilonTextBox.MaxLength = maxLength;
///     zeroXTextBox.MaxLength = maxLength;
/// 
/// 
/// Создать обработчик события нажатия на кнопку 
/// (двойной клик по Button на форме) и вызвать соответствующий
/// метод.
///     Draw для DrawButton_Click
///     Check для CheckButton_Click
/// 
/// В классе есть события ExtraDrawAction и ExtraCheckAction
/// которые имеют сигнатуру: void ():
/// 
///     ExtraDrawAction - выполняется дополнительное действие 
///     в методе Draw() (вызывается если график был отрисован)
///     
///     ExtraCheckAction - выполняется доплнительное дейстивие
///     в методе Check() (вызывается если введённые данных были 
///     корректными)
/// 
/// 
/// Необходимо создать обработчик загрузки формы (двойное нажатие
/// на форму):
///     FormsName_Load(object sender, EventArgs e)
///     
///     В нём необходимо добавить ранее созданный график на форму
///     (plotView - поле базового класса):
///         this.Controls.Add(plotView); 
///     
///     Далее надо создать график (graphic - поле базового класса).
///     Готовые графики есть в классах Graphics и UserGraphics
///         this.graphic = ClassName.GetSomeGraphic(minValue, maxValue, step);
///         
///     Добавление точек графика в поле points:
///         this.points.AddRange(this.graphic.Points.GetRange(0, this.graphic.Points.Count));
///         
///     Добавление графика на рабочую область:
///         this.plotView.Model.Series.Add(graphic);
/// 
/// 
/// Update:
/// 
///     Добавлены обработчики событий для кнопок 'Q'-'E', 'W'-'S'
///     'Q' - уменьшение значения delta на step едениц
///     'E' - увеличение значения delta на step едениц
///     
///     'S' - уменьшение значения epsilon на step едениц
///     'W' - увеличение значения epsilon на step едениц
/// 
/// 
/// Пример кода находится в ExampleForm.cs
/// 
/// </summary>
namespace MathGraphics
{
    /// <summary>
    /// Базовый класс для всех форм с графиками
    /// </summary>
    public partial class BaseForm : Form
    {
        private readonly IUserLocalization userInterface;

        public BaseForm()
        {
            this.userInterface = new RussianLocalization();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            formsSize = new Size(formsWidth, formsHeight);
            plotsSize = new Size(plotsWidth, plotsHeight);
            plotLocation = new Point(0, 0);

            points = new List<DataPoint>();

            plotView = new PlotView
            {
                Model = new PlotModel()
            };

            var plotController = new PlotController();

            plotView.Controller = plotController;

            plotController.BindKeyDown(OxyKey.A, null);

            plotView.Model.TextColor = ColorResources.ModelTextColor;

            AxisBuilder.SetVerticalAxis(plotView, yMinValue, yMaxValue, ColorResources.AxisColor);
            AxisBuilder.SetGorizontalAxis(plotView, xMinValue, xMaxValue, ColorResources.AxisColor);
        }
    }
}
