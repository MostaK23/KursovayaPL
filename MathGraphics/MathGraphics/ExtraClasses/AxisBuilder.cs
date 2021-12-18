using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace MathGraphics
{
    public static class AxisBuilder
    {
        /// <summary>
        /// Настройка оси Y
        /// </summary>
        /// <param name="plotView">Текущее PlotView</param>
        /// <param name="yMinValue">Минимальное значение по оси Y</param>
        /// <param name="yMaxValue">Максимальное значение по оси Y</param>
        /// <param name="axisColor">Цвет оси Y</param>
        public static void SetVerticalAxis(PlotView plotView, double yMinValue, double yMaxValue, OxyColor axisColor)
        {
            plotView.Model.Axes.Add(new LinearAxis
            {
                PositionAtZeroCrossing = true,
                Position = AxisPosition.Right,
                AbsoluteMaximum = yMaxValue,
                AbsoluteMinimum = yMinValue,
                MajorGridlineStyle = LineStyle.Solid 
            });

            plotView.Model.Series.Add(GetVerticalAxis(yMinValue, yMaxValue, axisColor));
        }

        /// <summary>
        /// Настройка оси X
        /// </summary>
        /// <param name="plotView">Текущий PlotView</param>
        /// <param name="xMinValue">Максимальное значение по оси X</param>
        /// <param name="xMaxValue">Минимальное значение по оси X</param>
        /// <param name="axisColor">Цвет оси X</param>
        public static void SetGorizontalAxis(PlotView plotView, double xMinValue, double xMaxValue, OxyColor axisColor)
        {
            plotView.Model.Axes.Add(new LinearAxis
            {
                PositionAtZeroCrossing = true,
                Position = AxisPosition.Bottom,
                AbsoluteMaximum = xMaxValue,
                AbsoluteMinimum = xMinValue,
                AxislineColor = axisColor,
                MajorGridlineStyle = LineStyle.Solid,
            });

            plotView.Model.Series.Add(AxisBuilder.GetGorizontalAxis(xMinValue, xMaxValue, axisColor));
        }

        private static FunctionSeries GetVerticalAxis(double min, double max, OxyColor color)
        {
            var functionSeries = new FunctionSeries()
            {
                Color = color,
                Title = TextResources.YAxis,
            };

            const int X = 0;

            functionSeries.Points.Add(new DataPoint(X, min));
            functionSeries.Points.Add(new DataPoint(X, max));

            return functionSeries;
        }

        private static FunctionSeries GetGorizontalAxis(double min, double max, OxyColor color)
        {
            var functionSeries = new FunctionSeries()
            {
                Color = color,
                Title = TextResources.XAxis,
            };

            const int Y = 0;

            functionSeries.Points.Add(new DataPoint(min, Y));
            functionSeries.Points.Add(new DataPoint(max, Y));

            return functionSeries;
        }
    }
}
