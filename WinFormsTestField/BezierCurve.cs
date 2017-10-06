using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using ZedGraph;

namespace biomedical_signals_hardware_emulator_winforms
{
    class BezierCurve
    {
        #region Dafa fields
        private PointPairList userPoints;
        private PointPairList bezierCurvePoints;
        private ZedGraphControl chartControl;
        #endregion

        #region Properties

        public PointPairList BezierPoinds { get { return this.bezierCurvePoints; } }
        public PointPairList UserPoints { get { return this.userPoints; } }

        #endregion

        #region Contructors
        public BezierCurve(ZedGraphControl control)
        {
            this.chartControl = control;
            this.userPoints = new PointPairList();
            this.bezierCurvePoints = new PointPairList();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Add user points to chart
        /// </summary>
        /// <param name="pF"></param>
        public void AddPoint(PointF pF)
        {
            double x, y = 0;
            GraphPane pane = chartControl.GraphPane;
            pane.ReverseTransform(pF, out x, out y);
            userPoints.Add(x, y);
            if (userPoints.Count != 1)
                CheckCurrentPoint(userPoints.Count - 1);         
            RefreshChart();
        }

        /// <summary>
        /// Edit user point based on index number
        /// </summary>
        /// <param name="point"></param>
        /// <param name="index"></param>
        public void EditPoint(PointPair point, int index)
        {
            userPoints.RemoveAt(index);
            userPoints.Insert(index, point);
            CheckCurrentPoint(index);
            RefreshChart();
        }

        /// <summary>
        /// Recalculate Bezier points and refresh chart
        /// </summary>
        public void RefreshChart()
        {
            GraphPane pane = chartControl.GraphPane;
            while (pane.CurveList.Count > 0)
            {
                pane.CurveList.RemoveAt(pane.CurveList.Count - 1);
            }
            CalculateBezier();
            pane.AddCurve("User points", userPoints, Color.Black, SymbolType.Circle);
            pane.AddCurve("Bezier curve", bezierCurvePoints, Color.Red, SymbolType.None);
            chartControl.AxisChange();
            chartControl.Invalidate();
            chartControl.Refresh();
        }

        /// <summary>
        /// Remove all points from chart
        /// </summary>
        public void Clear()
        {
            userPoints.Clear();
            bezierCurvePoints.Clear();
            chartControl.Refresh();
        }

        /// <summary>
        /// Reverse adding point direction
        /// </summary>
        public void Reverse()
        {
            userPoints.Reverse();
            CalculateBezier();
            chartControl.Refresh();
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Calculate Bezier points
        /// </summary>
        void CalculateBezier()
        {
            bezierCurvePoints.Clear();
            switch (userPoints.Count)
            {
                case 0:
                case 1:
                    break;
                case 2:
                    bezierCurvePoints = userPoints.Clone();
                    break;
                default:
                    RecursiveSearchPoints(userPoints.Clone());
                    break;
            }
        }

        /// <summary>
        /// Search Bezier points recursively
        /// </summary>
        /// <param name="points">User points for Bezier points calculations</param>
        void RecursiveSearchPoints(PointPairList points)
        {
            for (int i = 0; i<1000; i++)
            {
                float t = (float)i / 999;
                bezierCurvePoints.Add(LineDivider(points.Clone(), t));
            }
        }

        /// <summary>
        /// User line divider
        /// </summary>
        /// <param name="points"></param>
        /// <param name="t">Value from 0 to 1 which determine point location</param>
        /// <returns>PointPair point</returns>
        PointPair LineDivider(PointPairList points, float t)
        {
            PointPairList dividedPoints = new PointPairList();
            while (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    dividedPoints.Add(CalculatePoint(points.ElementAt(i), points.ElementAt(i + 1), t));
                }
                points = dividedPoints.Clone();
                dividedPoints.Clear();
            }
            return points.ElementAt(0);
        }

        /// <summary>
        /// Calculate new point for dividing
        /// </summary>
        /// <param name="a">First point, line begin</param>
        /// <param name="b">Second point, line end</param>
        /// <param name="t">Value from 0 to 1 which determine point location</param>
        /// <returns>PointPair point</returns>
        PointPair CalculatePoint(PointPair a, PointPair b, float t)
        {
            PointPair point = new PointPair();
            point.X = a.X + (b.X - a.X) * t;
            point.Y = a.Y + (b.Y - a.Y) * t;

            return point;
        }

        /// <summary>
        /// Check for proper X value of current point in userPoint PointPairList
        /// </summary>
        /// <param name="index">Index for current point in userPoint PointPairList</param>
        void CheckCurrentPoint(int index)
        {
            if (index == 0)
            {
                if (index < userPoints.Count - 1 && userPoints.ElementAt(index).X > userPoints.ElementAt(index + 1).X)
                    userPoints.ElementAt(index).X = userPoints.ElementAt(index + 1).X;
            }
            else if (index == userPoints.Count - 1)
            {
                if (index > 0 && userPoints.ElementAt(index).X < userPoints.ElementAt(index - 1).X)
                    userPoints.ElementAt(index).X = userPoints.ElementAt(index - 1).X;
            }
            else if (index > 0 && index < userPoints.Count - 1)
            {
                if (userPoints.ElementAt(index).X < userPoints.ElementAt(index - 1).X)
                    userPoints.ElementAt(index).X = userPoints.ElementAt(index - 1).X;
                if (userPoints.ElementAt(index).X > userPoints.ElementAt(index + 1).X)
                    userPoints.ElementAt(index).X = userPoints.ElementAt(index + 1).X;
            }
            else
                throw new IndexOutOfRangeException();
        }
        #endregion
    }
}
