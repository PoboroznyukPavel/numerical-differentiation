using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace VM_Kurs
{
    public partial class Form1 : Form
    {

        double x0;
        double T = 0; //докуда
        int N; //кол-во точек
        double h;  //шаг = T/N
        double[] t;
        double[] x1;
        double[] x;
        double lasth;
        double lasth2;

        public Form1()
        {
            InitializeComponent();
            Calculate();
        }



        public double f(double x)
        {
            double fx = Math.Pow(Math.E, -Math.Cos(x)) * Math.Sin(2.0 - x) / (3.0 + Math.Cos(3.0 - x));
            return fx;
        }

        public double f(double x, double t)
        {
            double fx = Math.Pow(Math.E, -Math.Cos(x)) * Math.Sin(2.0 - x) / (3.0 + Math.Cos(3.0 - x));
            return fx;
        }

        public static void FillGraph(ZedGraphControl zg, double[] x, double[] y, string name)
        {
            GraphPane pane = zg.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            for (int i = 0; i < x.Length; i++)
            {
                list.Add(x[i], y[i]);
            }
            LineItem curve = pane.AddCurve(name, list, Color.Blue, SymbolType.None);
            zg.AxisChange();
            zg.Invalidate();
        }

        public static void AddGraph(ZedGraphControl zg, double[] x, double[] y, string name)
        {
            GraphPane pane = zg.GraphPane;
            PointPairList list = new PointPairList();
            for (int i = 0; i < x.Length; i++)
            {
                list.Add(x[i], y[i]);
            }
            LineItem curve = pane.AddCurve(name, list, Color.Red, SymbolType.None);
            zg.AxisChange();
            zg.Invalidate();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                T = Convert.ToDouble(textBoxT.Text);
                N = Convert.ToInt32(textBoxN.Text);
                x0 = Convert.ToDouble(textBoxx0.Text);
                h = T / N;
                t = new double[N];
                x1 = new double[N];
                x = new double[N];
                t[0] = x0;
                for (int i = 0; i < N - 1; i++)
                    t[i + 1] = t[i] + h;

                for (int i = 0; i < N; i++)
                    x1[i] = f(t[i]);

                FillGraph(zedGraphControl1, t, x1, "f(x), h");
                Hemming();
                FillGraph(zedGraphControl2, t, x, "F(x), h");
                lasth = x[N - 1];

                N *= 2;
                h = T / N;
                t = new double[N];
                x1 = new double[N];
                x = new double[N];
                t[0] = x0;
                for (int i = 0; i < N - 1; i++)
                    t[i + 1] = t[i] + h;

                for (int i = 0; i < N; i++)
                    x1[i] = f(t[i]);

                AddGraph(zedGraphControl1, t, x1, "f(x), h/2");
                Hemming();
                AddGraph(zedGraphControl2, t, x, "F(x), h/2");
                lasth2 = x[N - 1];

                textBoxErr.Text = (Math.Abs((lasth2 - lasth) * 4.0 / 3.0)).ToString();
            }
            catch (System.Exception s)
            {
                textBoxT.Text = "10,0";
                textBoxN.Text = "100";
                textBoxx0.Text = "0,0";
                textBoxErr.Text = "Ошибка: в полях должны быть записаны числа соотв. им типа";
            }
            
        }


        public double GetK1(double x, double t)
        {
            return h * f(x, t);
        }

        public double GetK2(double x, double t)
        {
            return h * f(x + GetK1(x, t) / 2.0, t + h / 2.0);
        }

        public double GetK3(double x, double t)
        {
            return f(x + GetK2(x, t) / 2.0, t + h / 2.0);
        }

        public double GetK4(double x, double t)
        {
            return f(x + GetK3(x, t), t + h);
        }

        public void Hemming()
        {
            double[] pred = new double[N];
            double[] d = new double[N];
            double[] corr = new double[N];
            x[0] = x0;
            x[1] = x[0] + 1.0 / 6.0 * (GetK1(x[0], t[0]) + 2.0 * GetK2(x[0], t[0]) + 2.0 * GetK3(x[0], t[0]) + GetK4(x[0], t[0]));
            x[2] = x[1] + 1.0 / 6.0 * (GetK1(x[1], t[1]) + 2.0 * GetK2(x[1], t[1]) + 2.0 * GetK3(x[1], t[1]) + GetK4(x[1], t[1]));
            //прогноз
            for (int i = 3; i < N - 1; i++)
            {
                pred[i + 1] = ( x[i - 3] + 4.0 / 3.0 * h * (2.0 * x1[i] - x1[i - 1] + 2.0 * x1[i - 2]));
               // pred[i + 1] = (2.0 * x[i] - 1.0 + x[i - 2]) / 3.0 + h * (191.0*x1[i] - 107.0*x1[i - 1] + 109.0*x1[i - 2] - 25.0*x1[i - 3])/ 72.0;
            /*//поправка
                d[i + 1] = (2.0 * x[i] - 1.0 + x[i - 2]) / 3.0 + h * (191.0 * x1[i] - 107.0 * x1[i - 1] + 109.0 * x1[i - 2] - 25.0 * x1[i - 3]) / 72.0;
            //коррекция
                corr[i+1] = (2.0*x1[i-1] + x1[i-2])/3.0 + h*(25.0*f(x[i+1],d[i+1]) + 91.0*x1[i] + 43.0*x1[i-1] +9.0*x1[i-2])/72.0;*/
                x[i + 1] = 1.0 / 8.0 * (9.0 * x[i] - x[i - 2] + 3.0 * h * (x1[i + 1] + 2.0 * x1[i] - x1[i - 1]));
             //вычисление
             /*    x[i + 1] = corr[i + 1] + (43.0 / 750.0) * (d[i + 1] - corr[i + 1]);}*/
            }

        }

       
    }
}
