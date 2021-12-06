using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maoi_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<double> Wave_1 = new List<double>();
        public List<double> Wave_2 = new List<double>();
        public List<double> Sinewave = new List<double>();
        public List<double> DFT = new List<double>();
        public List<double> Sinewave_Goertzel = new List<double>();
        public List<double> Sinewave_OptiGoertzel = new List<double>();

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            List_Clear();
            double[,] inp = new double[3, Convert.ToInt32(textBoxIteration.Text)];
            Add_wave(inp);
            Create_sinewave(inp);
            Create_Chart();
            Time();
        }

        public void Add_wave(double[,] inp)
        {

            double PE = 3.14;

            double amplitude1 = Convert.ToDouble(textBoxAmplitude1.Text);
            double often1 = Convert.ToDouble(textBoxOften1.Text);
            double faza1 = Convert.ToDouble(textBoxFaza1.Text);

            double amplitude2 = Convert.ToDouble(textBoxAmplitude2.Text);
            double often2 = Convert.ToDouble(textBoxOften2.Text);
            double faza2 = Convert.ToDouble(textBoxFaza2.Text); ;

            for (int p = 0; p < Convert.ToInt32(textBoxIteration.Text); p++)
            {
                inp[0, p] = amplitude1 * Math.Sin(2 * PE * often1 * p + faza1 * PE / 180);
                inp[1, p] = amplitude2 * Math.Sin(2 * PE * often2 * p + faza2 * PE / 180);
                inp[0, p] = Math.Round(inp[0, p], 5);
                inp[1, p] = Math.Round(inp[1, p], 5);
                dataGridViewOtput.Rows.Add(inp[0, p], inp[1, p]);
                Wave_1.Add(inp[0, p]);
                Wave_2.Add(inp[1, p]);
            }

        }

        void Create_sinewave(double[,] inp)
        {
            for (int p = 0; p < Convert.ToInt32(textBoxIteration.Text); p++)
            {
                inp[2, p] = inp[1, p] + inp[0, p];
                inp[2, p] = Math.Round(inp[2, p], 5);
                Sinewave.Add(inp[2, p]);
                dataGridViewOtput.Rows[p].Cells[2].Value = inp[2, p];
            }
        }

        void Dft(double[] a, int n, int N, int count)
        {
            N = a.Length;
            Complex o = Complex.ImaginaryOne;
            Complex[] b = new Complex[N];

            for (n = 0; n < N; n++)
            {
                b[n] = new Complex();
                for (int k = 0; k < N; k++)
                {
                    b[n] += a[k] * Complex.Exp((-2.0 * o * Math.PI * n * k) / N);
                }

                DFT.Add(b[n].Magnitude);
                dataGridViewOtput.Rows[n].Cells[3].Value = b[n].Magnitude;
                if (count == 0)
                chartDFT.Series[0].Points.AddXY(n + 1, DFT[n]);
            }
        }

        void Goertzel(double[] input, int k)
        {
            int N = input.Length;
            double[] output = new double[2];
            double[] temp = new double[N];
            double a = 2 * Math.Cos(2 * Math.PI * k / N), a2 = (2 * Math.PI * k / N) * (N - 1);
            double wr = Math.Cos(2 * Math.PI * k / N);
            double wi = Math.Sin(2 * Math.PI * k / N);
            temp[0] = input[0];
            temp[1] = input[1] + a * temp[0];
            for (int n = 2; n < N; n++)

                temp[n] = input[n] + a * temp[n - 1] - temp[n - 2];

            output[0] = Math.Sqrt(Math.Pow(temp[N - 1] * wr - temp[N - 2], 2) + Math.Pow(temp[N - 1] * wi, 2));
            output[1] = (Math.Atan((temp[N - 1] * wi) / (temp[N - 1] * wr - temp[N - 2]))) / Math.PI * 180;

            Sinewave_Goertzel.Add(output[0]);
            dataGridViewOtput.Rows[k].Cells[4].Value = output[0];
        }

        void OptiGoertzel(double[] input, int k)
        {
            int N = input.Length;
            double output;
            double[] temp = new double[N];
            double a = 2 * Math.Cos(2 * Math.PI * k / N), a2 = (2 * Math.PI * k / N) * (N - 1);
            double wr = Math.Cos(2 * Math.PI * k / N);
            double wi = Math.Sin(2 * Math.PI * k / N);
            temp[0] = input[0];
            temp[1] = input[1] + a * temp[0];
            for (int n = 2; n < N; n++)

                temp[n] = input[n] + a * temp[n - 1] - temp[n - 2];

            output = Math.Sqrt(Math.Pow(temp[N - 1], 2) + Math.Pow(temp[N - 2], 2) - temp[N - 1] * temp[N - 2] * a);

            Sinewave_OptiGoertzel.Add(output);
            dataGridViewOtput.Rows[k].Cells[5].Value = output;
        }

        void Time()
        {
            double[] x = Sinewave.ToArray();
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 1000; i++) for (int j = 0; j < x.Length; j++)
                    Goertzel(x, j);
            s.Stop();
            TimeSpan ts = s.Elapsed;
            dataGridViewOtput.Columns[4].HeaderText = "Goertzel " + Convert.ToString(ts.TotalMilliseconds) + " ms";

           s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 1000; i++) for (int j = 0; j < x.Length; j++)
                    OptiGoertzel(x, j);
            s.Stop();
            ts = s.Elapsed;
            dataGridViewOtput.Columns[5].HeaderText = "OptiGoertzel " + Convert.ToString(ts.TotalMilliseconds) + " ms";

            s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 1000; i++)
                Dft(x, Convert.ToInt32(textBoxIteration.Text), Convert.ToInt32(textBoxIteration.Text) * 2, i);
            s.Stop();
            ts = s.Elapsed;
            dataGridViewOtput.Columns[3].HeaderText = "DFT " + Convert.ToString(ts.TotalMilliseconds) + " ms";
        }

        void Create_Chart()
        {
            for (int i = 0; i < Sinewave.Count; i++)
            {
                chartOutput.Series[0].Points.AddXY(i + 1, Wave_1[i]);
                chartOutput.Series[1].Points.AddXY(i + 1, Wave_2[i]);
                chartOutput.Series[2].Points.AddXY(i + 1, Sinewave[i]);
            }
        }
        void List_Clear()
        {
            chartOutput.Series[0].Points.Clear();
            chartOutput.Series[1].Points.Clear();
            chartOutput.Series[2].Points.Clear();
            chartDFT.Series[0].Points.Clear();
            Wave_1 = new List<double>();
            Wave_2 = new List<double>();
            Sinewave = new List<double>();
            DFT = new List<double>();
            Sinewave_Goertzel = new List<double>();
            Sinewave_OptiGoertzel = new List<double>();
            dataGridViewOtput.Rows.Clear();
        }
    }
}
