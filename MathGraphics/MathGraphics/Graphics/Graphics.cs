using System;
using OxyPlot;
using OxyPlot.Series;

namespace MathGraphics
{
    public static class Graphics
    {
        /// <summary>
        /// Функция косинуса
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetCosGraphic(double start, double end, double step)
        {
            return new FunctionSeries(Math.Cos, start, end, step, "cos(x)")
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// Функция косинуса
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static FunctionSeries GetCosGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(Math.Cos, start, end, step, "cos(x)")
            {
                Color = color
            };
        }

        /// <summary>
        /// Функция синуса
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetSinGraphic(double start, double end, double step)
        {
            return new FunctionSeries(Math.Sin, start, end, step, "sin(x)")
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// Функция синуса
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static FunctionSeries GetSinGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(Math.Sin, start, end, step, "sin(x)")
            {
                Color = color
            };
        }

        /// <summary>
        /// Функиця параболы
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetParabolaGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => x * x, start, end, step, "x^2")
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// Функиця параболы
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static FunctionSeries GetParabolaGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(x => x * x, start, end, step, "x^2")
            {
                Color = color
            };
        }

        /// <summary>
        /// Кубическая функция
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetCubicalGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => Math.Pow(x, 3), start, end, step, "x^3")
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// Кубическая функция
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static FunctionSeries GetCubicalGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(x => Math.Pow(x, 3), start, end, step, "x^3")
            {
                Color = color
            };
        }

        /// <summary>
        /// Функция sin(x)/x
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetSinXDevXGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => Math.Sin(x) / x, start, end, step, "sin(x)/x") 
            { 
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// Функция sin(x)/x
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static FunctionSeries GetSinXDevXGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(x => Math.Sin(x) / x, start, end, step, "sin(x)/x")
            {
                Color = color
            };
        }

        /// <summary>
        /// График sqrt(x)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static FunctionSeries GetSqrtXGraphic(double start, double end, double step)
        {
            return new FunctionSeries(x => Math.Sqrt(x), start, end, step)
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// График 1 / x
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        private static FunctionSeries GetOneDivX(double start, double end, double step)
        {
            return new FunctionSeries(x => 1 / x, start, end, step, "1/x")
            {
                Color = ColorResources.DefaultGraphicColor,
            };
        }

        /// <summary>
        /// График 1 / x
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        private static FunctionSeries GetOneDivX(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(x => 1 / x, start, end, step, "1/x")
            {
                Color = color,
            };
        }

        /// <summary>
        /// График tan(x)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        private static FunctionSeries GetTangentGraphic(double start, double end, double step)
        {
            return new FunctionSeries(Math.Tan, start, end, step, "tan(x)")
            { 
                Color = ColorResources.DefaultGraphicColor, 
            };
        }

        /// <summary>
        /// График tan(x)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        private static FunctionSeries GetTangentGraphic(double start, double end, double step, OxyColor color)
        {
            return new FunctionSeries(Math.Tan, start, end, step, "tan(x)")
            {
                Color = color,
            };
        }
    }
}
