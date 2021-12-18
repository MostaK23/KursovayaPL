using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MathGraphics
{
    public partial class BaseForm
    {
        /// <summary>
        /// TextBox для ввода epsilon (надо создавать)
        /// </summary>
        protected TextBox epsilonTextBox;

        /// <summary>
        /// TextBox для ввода delta (надо создавать)
        /// </summary>
        protected TextBox deltaTextBox;

        /// <summary>
        /// TextBox для ввода x0 (надо создавать)
        /// </summary>
        protected TextBox x0TextBox;

        /// <summary>
        /// Максимальное значение на оси X
        /// </summary>
        protected double xMaxValue = 100;

        /// <summary>
        /// Минимальное значение на оси X
        /// </summary>
        protected double xMinValue = -100;

        /// <summary>
        /// Максимальное значение на оси Y
        /// </summary>
        protected double yMaxValue = 100;

        /// <summary>
        /// Минимальное значение на оси Y
        /// </summary>
        protected double yMinValue = -100;

        /// <summary>
        /// Максимальное значение принимаемое функцие
        /// </summary>
        protected double maxValue = 100;

        /// <summary>
        /// Минимальное значение принимаемое функцие
        /// </summary>
        protected double minValue = -100;

        /// <summary>
        /// Шаг прохождения функции
        /// </summary>
        protected double step = 0.01;

        /// <summary>
        /// Эпсилон
        /// </summary>
        protected double epsilon;

        /// <summary>
        /// Дельта
        /// </summary>
        protected double delta;

        /// <summary>
        /// Икс нулевое
        /// </summary>
        protected double x0;

        /// <summary>
        /// Ширина формы
        /// </summary>
        protected int formsWidth = 1000;

        /// <summary>
        /// Высота формы
        /// </summary>
        protected int formsHeight = 600;

        /// <summary>
        /// Размер формы
        /// </summary>
        protected Size formsSize;

        /// <summary>
        /// Ширина графика
        /// </summary>
        protected int plotsWidth = 800;

        /// <summary>
        /// Высота графика
        /// </summary>
        protected int plotsHeight = 500;

        /// <summary>
        /// Размер графика
        /// </summary>
        protected Size plotsSize;

        /// <summary>
        /// Расположение графика на форме
        /// </summary>
        protected Point plotLocation;

        /// <summary>
        /// Все точки графика
        /// </summary>
        protected List<DataPoint> points;

        protected delegate void ActionHandler();

        /// <summary>
        /// Используется в методе Draw() для выполнения
        /// дополнительных действий
        /// </summary>
        protected event ActionHandler ExtraDrawAction;

        /// <summary>
        /// Используется в методе Check() для выполнения
        /// дополнительных действий
        /// </summary>
        protected event ActionHandler ExtraCheckAction;

        /// <summary>
        /// Рабочая область для графика
        /// </summary>
        protected PlotView plotView;

        /// <summary>
        /// График
        /// </summary>
        protected FunctionSeries graphic;

        private FunctionSeries x0PlusDelta;

        private FunctionSeries x0MinusDelta;

        private FunctionSeries y0PlusEpsilon;

        private FunctionSeries y0MinusEpsilon;

        private FunctionSeries chosenPoint;

        private readonly int calculationAccuracy = 5;
    }
}
