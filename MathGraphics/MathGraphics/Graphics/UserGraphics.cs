using System;
using OxyPlot.Series;

namespace MathGraphics
{
    public static class UserGraphics
    {
        /// <summary>
        /// Функция: 2x^2 + 2x + 3
        /// </summary>
        /// <returns></returns>
        public static FunctionSeries GetFirstGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => 2 * x * x + 2 * x + 3, start, end, step, "2x^2 + 2x + 3");
        }
        
        public static FunctionSeries GetExpGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => Math.Pow(Math.E, x), start, end, step, "e^x");
        }
    }
}
