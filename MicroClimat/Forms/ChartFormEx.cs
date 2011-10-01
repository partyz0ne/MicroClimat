using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace MicroClimat.Forms
{
    public partial class ChartFormEx : Form
    {
        List<double> _lstPar1 = new List<double>();
        List<double> _lstPar2 = new List<double>();
        readonly List<DateTime> _lstDates = new List<DateTime>();
        List<int> _nValues = new List<int>();
        bool _bUse2Pars = true;

        String _strTitle = String.Empty;
        String _strYAxis = String.Empty;
        String _strParName = String.Empty;

        public String Title { set { _strTitle = value; } }
        public String YAxis { set { _strYAxis = value; } }
        public String ParName { set { _strParName = value; } }

        public ChartFormEx()
        {
            InitializeComponent();
        }

        public ChartFormEx(List<DateTime> lstDates)
        {
            InitializeComponent();
            _lstDates = lstDates;
        }

        public void MakeChartOf1Param(List<double> lstPar1)
        {
            _lstPar1 = lstPar1;
            _bUse2Pars = false;
            MakeChart();
        }

        public void MakeChartOf2Param(List<double> lstPar1, List<double> lstPar2)
        {
            _lstPar1 = lstPar1;
            _lstPar2 = lstPar2;
            MakeChart();
        }

        public void MakeWindRose(List<int> nValues)
        {
            _nValues = nValues;
            GraphPane pane = mainChart.GraphPane;
            pane.Title.Text = "Роза ветров";
            pane.IsFontsScaled = false;

            pane.CurveList.Clear();

            pane.XAxis.IsVisible = false;
            pane.YAxis.IsVisible = false;

            pane.XAxis.MajorGrid.IsVisible = false;
            pane.YAxis.MajorGrid.IsVisible = false;

            pane.YAxis.MajorGrid.IsZeroLine = false;

            // Создаем список точек 
            var points = new RadarPointList {Clockwise = true};

            var text = new TextObj[8];
            var axText = new TextObj[8];
            for (int i = 0; i < 8; i++)
                points.Add(_nValues[i], 1);

            int nMax = _nValues.Concat(new[] {0}).Max();
            nMax += 1;

            for (int i = 0; i < points.Count - 1; i++)
            {
                text[i] = new TextObj(_nValues[i].ToString(), points[i].X, points[i].Y);
                text[i].FontSpec.Border.IsVisible = false;
                Color color;
                if (_nValues[i] < nMax / 3)
                    color = Color.GreenYellow;
                else
                    if (_nValues[i] < (nMax / 3) * 2)
                        color = Color.Yellow;
                    else
                        color = Color.OrangeRed;
                text[i].FontSpec.Fill = new Fill(color);
                text[i].FontSpec.IsBold = true;
                pane.GraphObjList.Add(text[i]);
            }

            // Добавляем кривую по этим четырем точкам
            LineItem myCurve = pane.AddCurve("", points, Color.Blue, SymbolType.Triangle);
            myCurve.Line.Width = 2.5F;

            // Для наглядности нарисуем расстояния от начала координат до каждой из точек
            var arrow = new LineObj[8];
            arrow[0] = new LineObj(0, 0, 0, nMax);
            arrow[1] = new LineObj(0, 0, -nMax, 0);
            arrow[2] = new LineObj(0, 0, 0, -nMax);
            arrow[3] = new LineObj(0, 0, nMax, 0);
            arrow[4] = new LineObj(0, 0, nMax, nMax);
            arrow[5] = new LineObj(0, 0, -nMax, nMax);
            arrow[6] = new LineObj(0, 0, nMax, -nMax);
            arrow[7] = new LineObj(0, 0, -nMax, -nMax);

            axText[0] = new TextObj("с", 0, nMax);
            axText[1] = new TextObj("з", -nMax, 0);
            axText[2] = new TextObj("ю", 0, -nMax);
            axText[3] = new TextObj("в", nMax, 0);
            axText[4] = new TextObj("с/в", nMax, nMax);
            axText[5] = new TextObj("с/з", -nMax, nMax);
            axText[6] = new TextObj("ю/в", nMax, -nMax);
            axText[7] = new TextObj("ю/з", -nMax, -nMax);

            for (int i = 0; i < 8; i++)
            {
                pane.GraphObjList.Add(axText[i]);
                pane.GraphObjList.Add(arrow[i]);
            }

            // Отметим начало координат черным квадратиком
            var box = new BoxObj(-0.05, 0.05, 0.1, 0.1, Color.Black, Color.Black);
            pane.GraphObjList.Add(box);

            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = -nMax;
            pane.XAxis.Scale.Max = nMax;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -nMax;
            pane.YAxis.Scale.Max = nMax;

            mainChart.AxisChange();
            mainChart.Invalidate();
        }

        private void MakeChart()
        {
            GraphPane pane = mainChart.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = _strTitle;
            pane.YAxis.Title.Text = _strYAxis;
            pane.IsFontsScaled = false;

            if (_bUse2Pars)
            {
                var listDry = new PointPairList();
                var listWet = new PointPairList();
                for (int i = 0; i < _lstPar1.Count; i++)
                {
                    listDry.Add(new XDate(_lstDates[i]), _lstPar1[i]);
                    listWet.Add(new XDate(_lstDates[i]), _lstPar2[i]);
                }
//                LineItem curveDry = pane.AddCurve("Сух.", listDry, Color.Blue, SymbolType.Square);
//                LineItem curveWet = pane.AddCurve("Смоч.", listWet, Color.Red, SymbolType.Square);
            }
            else
            {
                var listPres = new PointPairList();
                for (int i = 0; i < _lstPar1.Count; i++)
                {
                    listPres.Add(new XDate(_lstDates[i]), _lstPar1[i]);
                }
//                LineItem curvePress = pane.AddCurve(m_strParName, listPres, Color.Green, SymbolType.Square);
            }
            pane.XAxis.Type = AxisType.DateAsOrdinal;
            pane.XAxis.Title.Text = "Дата/время наблюдения";
            mainChart.AxisChange();
            mainChart.Invalidate();
        }

        private void SaveMenuItemClick(object sender, EventArgs e)
        {
            mainChart.SaveAsBitmap();
        }

        private void PrintMenuItemClick(object sender, EventArgs e)
        {
            mainChart.DoPrint();
        }
    }
}
