using OxyPlot.Series;

namespace MathGraphics
{
    public static class GraphicProvider
    {
        public static FunctionSeries GetGraphic(int index, double start, double end, double step)
        {
            switch (index)
            {
                case 0:
                    return Graphics.GetParabolaGraphic(start, end, step);
                case 1:
                    return Graphics.GetCosGraphic(start, end, step);
                case 2:
                    return Graphics.GetSinGraphic(start, end, step);
                case 3:
                    return Graphics.GetCubicalGraphic(start, end, step);
                default:
                    return null;
            }
        }
    }
}
