using OxyPlot;
using OxyPlot.Series;
using System;
using System.Windows.Forms;

namespace MathGraphics
{
    public partial class BaseForm
    {
        private readonly Keys checkButton = Keys.Space;
        private readonly Keys drawButton = Keys.Space;
        private readonly Keys toRightButton = Keys.D;
        private readonly Keys toLeftButton = Keys.A;
        private readonly Keys increaseDeltaButton = Keys.E;
        private readonly Keys decreaseDeltaButton = Keys.Q;
        private readonly Keys increaseEpsilonButton = Keys.W;
        private readonly Keys decreaseEpsilonButton = Keys.S;

        protected void DrawGraphic(FunctionSeries graphic)
        {
            this.graphic = graphic;
            this.graphic.Color = ColorResources.DefaultGraphicColor;
            this.points.AddRange(this.graphic.Points.GetRange(0, this.graphic.Points.Count));

            this.plotView.Model.Series.Add(graphic);
        }

        protected void DrawSelectedGraphic(int index)
        {
            if (plotView.Model.Series.Contains(graphic))
            {
                plotView.Model.Series.Remove(graphic);
                points.Clear();
            }

            deltaTextBox.Text = string.Empty;
            epsilonTextBox.Text = string.Empty;
            x0TextBox.Text = string.Empty;
            
            ClearExtraLines();

            this.graphic = GraphicProvider.GetGraphic(index, minValue, maxValue, step);

            this.points.AddRange(this.graphic.Points.GetRange(0, this.graphic.Points.Count));

            this.plotView.Model.Series.Add(graphic);

            plotView.Model.InvalidatePlot(true);
        }

        protected void ClearExtraLines()
        {
            if (plotView.Model.Series.Contains(chosenPoint))
            {
                plotView.Model.Series.Remove(chosenPoint);
            }

            if (plotView.Model.Series.Contains(x0MinusDelta))
            {
                plotView.Model.Series.Remove(x0MinusDelta);
            }

            if (plotView.Model.Series.Contains(x0PlusDelta))
            {
                plotView.Model.Series.Remove(x0PlusDelta);
            }

            if (plotView.Model.Series.Contains(y0PlusEpsilon))
            {
                plotView.Model.Series.Remove(y0PlusEpsilon);
            }

            if (plotView.Model.Series.Contains(y0MinusEpsilon))
            {
                plotView.Model.Series.Remove(y0MinusEpsilon);
            }
        }

        protected void DrawOnButton(object sender, KeyEventArgs e)
        {
            if (IsInputCorrect(out _) && e.KeyCode == drawButton)
            {
                Draw();
            }
        }

        protected void CheckOnButton(object sender, KeyEventArgs e)
        {
            if (IsInputCorrect(out _) && e.KeyCode == checkButton && e.Modifiers == Keys.Control)
            {
                Check();
            }
        }

        #region Move Methods
        /// <summary>
        /// Перемещение x0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MoveZeroX(object sender, KeyEventArgs e)
        {
            if (IsInputCorrect(out _))
            {
                if (e.KeyCode == toRightButton && x0 + delta < xMaxValue - step && GetY0(x0) + epsilon < yMaxValue - step)
                {
                    x0 += step;
                }

                if (e.KeyCode == toLeftButton && x0 - delta > xMinValue + step && GetY0(x0) - epsilon > yMinValue + step)
                {
                    x0 -= step;
                }

                x0TextBox.Text = x0.ToString();
                Draw();
            }
        }

        /// <summary>
        /// Управление линиями Дельта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChangeDelta(object sender, KeyEventArgs e)
        {
            if (IsInputCorrect(out _))
            {
                if (e.KeyCode == decreaseDeltaButton && delta > step)
                {
                    delta -= step;
                }

                if (e.KeyCode == increaseDeltaButton && x0 + delta < xMaxValue - step)
                {
                    delta += step;
                }

                deltaTextBox.Text = delta.ToString();
                DrawHorizontalLines();
            }
        }

        /// <summary>
        /// Управление линиями Эпсилон
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChangeEpsilon(object sender, KeyEventArgs e)
        {
            if (IsInputCorrect(out _))
            {
                if (e.KeyCode == decreaseEpsilonButton && epsilon >= 2 * step)
                {
                    epsilon -= step;
                }

                if (e.KeyCode == increaseEpsilonButton && GetY0(x0) + epsilon < yMaxValue - step)
                {
                    epsilon += step;
                }

                epsilonTextBox.Text = epsilon.ToString();
                DrawVerticalLines();
            }
        }
        #endregion

        #region Draw Methods
        /// <summary>
        /// Построение эпсилон, дельта линий и выбранной точки
        /// </summary>
        protected void Draw()
        {
            if (IsInputCorrect(out string message))
            {
                DrawHorizontalLines();
                DrawVerticalLines();
                DrawChosenPoint();

                ExtraDrawAction?.Invoke();

                plotView.Model.InvalidatePlot(true);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        protected void DrawChosenPoint()
        {
            if (plotView.Model.Series.Contains(chosenPoint))
            {
                plotView.Model.Series.Remove(chosenPoint);
            }

            chosenPoint = new FunctionSeries()
            {
                MarkerType = MarkerType.Circle,
                Color = ColorResources.SelectedPointColor,
            };

            var y0 = GetY0(x0);

            chosenPoint.Points.Add(new DataPoint(x0, y0));

            plotView.Model.Series.Add(chosenPoint);
        }

        protected void DrawHorizontalLines()
        {
            if (plotView.Model.Series.Contains(y0PlusEpsilon))
            {
                plotView.Model.Series.Remove(y0PlusEpsilon);
            }

            if (plotView.Model.Series.Contains(y0MinusEpsilon))
            {
                plotView.Model.Series.Remove(y0MinusEpsilon);
            }

            y0PlusEpsilon = new FunctionSeries()
            {
                Color = ColorResources.HorizontalLineColor,
                Title = userInterface.Y0PlusEpsilon,
            };

            y0MinusEpsilon = new FunctionSeries()
            {
                Color = ColorResources.HorizontalLineColor,
                Title = userInterface.Y0MinusEpsilon,
            };

            var y0 = GetY0(x0);

            y0PlusEpsilon.Points.Add(new DataPoint(xMinValue, y0 + epsilon));
            y0PlusEpsilon.Points.Add(new DataPoint(xMaxValue, y0 + epsilon));

            y0MinusEpsilon.Points.Add(new DataPoint(xMinValue, y0 - epsilon));
            y0MinusEpsilon.Points.Add(new DataPoint(xMaxValue, y0 - epsilon));

            plotView.Model.Series.Add(y0PlusEpsilon);
            plotView.Model.Series.Add(y0MinusEpsilon);

            plotView.Model.InvalidatePlot(true);
        }

        protected void DrawVerticalLines()
        {
            if (plotView.Model.Series.Contains(x0MinusDelta))
            {
                plotView.Model.Series.Remove(x0MinusDelta);
            }

            if (plotView.Model.Series.Contains(x0PlusDelta))
            {
                plotView.Model.Series.Remove(x0PlusDelta);
            }

            x0PlusDelta = new FunctionSeries()
            {
                Color = ColorResources.VerticalLineColor,
                Title = userInterface.X0PlusDelta,
            };

            x0MinusDelta = new FunctionSeries()
            {
                Color = ColorResources.VerticalLineColor,
                Title = userInterface.X0MinusDelta,
            };

            x0PlusDelta.Points.Add(new DataPoint(x0 + delta, yMinValue));
            x0PlusDelta.Points.Add(new DataPoint(x0 + delta, yMaxValue));

            x0MinusDelta.Points.Add(new DataPoint(x0 - delta, yMinValue));
            x0MinusDelta.Points.Add(new DataPoint(x0 - delta, yMaxValue));

            plotView.Model.Series.Add(x0PlusDelta);
            plotView.Model.Series.Add(x0MinusDelta);

            plotView.Model.InvalidatePlot(true);
        }

        #endregion
        /// <summary>
        /// Проверка на вход и выход графика 
        /// </summary>
        protected void Check()
        {
            if (IsInputCorrect(out string message))
            {
                var y0 = GetY0(x0);
                var enterY = GetY0(x0 - delta);
                var exitY = GetY0(x0 + delta);

                if (y0 + epsilon > enterY && y0 - epsilon < enterY &&
                    y0 + epsilon > exitY && y0 - epsilon < exitY)
                {
                    MessageBox.Show(userInterface.RightEpsilonAndDelta);
                }
                else
                {
                    MessageBox.Show(userInterface.WrongEpsilonAndDelta);
                }

                ExtraCheckAction?.Invoke();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        protected double GetY0(double x0)
        {
            foreach (var p in points)
            {
                if (Math.Round(p.X, calculationAccuracy) == Math.Round(x0, calculationAccuracy))
                {
                    return Math.Round(p.Y, calculationAccuracy);
                }
            }

            return double.NaN;
        }

        protected bool IsInputCorrect(out string message)
        {
            if (string.IsNullOrWhiteSpace(deltaTextBox.Text) ||
                string.IsNullOrWhiteSpace(epsilonTextBox.Text) ||
                string.IsNullOrWhiteSpace(x0TextBox.Text))
            {
                message = userInterface.FillAllFields;
                return false;
            }

            if (!double.TryParse(deltaTextBox.Text, out delta) ||
                !double.TryParse(epsilonTextBox.Text, out epsilon) ||
                !double.TryParse(x0TextBox.Text, out x0))
            {
                message = userInterface.IncorrectValue;
                return false;
            }

            if (delta <= 0)
            {
                message = userInterface.DeltaMoreThanZero;
                return false;
            }

            if (epsilon <= 0)
            {
                message = userInterface.EpsilonMoreThanZero;
                return false;
            }

            if (x0 < xMinValue)
            {
                message = string.Format(userInterface.MinValue, xMinValue);
                return false;
            }

            if (x0 > xMaxValue)
            {
                message = string.Format(userInterface.MaxValue, xMaxValue);
                return false;
            }

            if (x0 + delta > xMaxValue || x0 - delta < xMinValue)
            {
                message = userInterface.WrongDeltaForX0;
                return false;
            }

            var y0 = GetY0(x0);

            if (y0 > yMaxValue || y0 < yMinValue)
            {
                message = userInterface.WrongX0ForY0;
                return false;
            }

            if (y0 + epsilon > maxValue || y0 - epsilon < minValue)
            {
                message = userInterface.WrongEpsilonForY0;
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
