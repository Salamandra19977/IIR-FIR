using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Form2 fr = new Form2();

        public List<double> Wave_1 = new List<double>();
        public List<double> Wave_2 = new List<double>();
        public List<double> Sinewave = new List<double>();
        public List<double> Sinewave_FIR = new List<double>();
        public List<double> Sinewave_IIR = new List<double>();

        public double[] coeffs = new double[] {
        0.023434548635770124,
        - 0.056537829917584249,
        - 0.040025935233797313,
        0.091764496396069706,
        0.28857865343342576,
        0.38506292667056707,
        0.28857865343342576,
        0.091764496396069706,
        - 0.040025935233797313,
        - 0.056537829917584249,
        0.023434548635770124};

        double[] a = new double[] { 1, -0.31049140353438615 };
        double[] b = new double[] { 1, 1.9999999999999998 };

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            List_Clear();
            double[,] inp = new double[3, Convert.ToInt32(textBoxIteration.Text)];
            Add_wave(inp);
            Create_sinewave(inp);
            Create_Chart();
            FIR(coeffs, Sinewave.ToArray());
            IIR(a, b, Sinewave.ToArray());
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

        void FIR(double[] b, double[] x)
        {
            double[] y = new double[x.Length];
            for (int yi = 0; yi < x.Length; yi++)
            {
                double t = 0.0;
                for (int bi = b.Length - 1; bi >= 0; bi--)
                {
                    if (yi - bi < 0) continue;
                    t += b[bi] * x[yi - bi];
                }
                y[yi] = t;
            }

            for (int i = 0; i < y.Length; i++)
            {
                Sinewave_FIR.Add(y[i]);
                chartOutput.Series[3].Points.AddXY(i + 1, Sinewave_FIR[i]);
                fr.chartOutput.Series[3].Points.AddXY(i + 1, Sinewave_FIR[i]);
                dataGridViewOtput.Rows[i].Cells[3].Value = y[i];
            }
        }

        void IIR(double[] ai, double[] bi, double[] x)
        {
            double aTemp = 0, aTemp2 = 0;
            double[] temp = new double[x.Length];
            for (int i = 0; i < x.Length; i++) temp[i] = 0;
            double[] ans = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = temp.Length - 1; j > 0; j--) temp[j] = temp[j - 1]; temp[0] = x[i];
                for (int j = 0; j < bi.Length; j++) ans[i] += temp[j] * bi[j];
                for (int j = 1; j < ai.Length; j++) aTemp += ai[j] * temp[j - 1];
                ans[i] += aTemp2; aTemp2 = aTemp; aTemp = 0;
            }

            for (int i = 0; i < ans.Length; i++)
            {
                Sinewave_IIR.Add(ans[i]);
                chartOutput.Series[4].Points.AddXY(i + 1, Sinewave_IIR[i]);
                fr.chartOutput.Series[4].Points.AddXY(i + 1, Sinewave_IIR[i]);
                dataGridViewOtput.Rows[i].Cells[4].Value = ans[i];
            }

        }

        void Create_Chart()
        {
            for (int i = 0; i < Sinewave.Count; i++)
            {
                chartOutput.Series[0].Points.AddXY(i + 1, Wave_1[i]);
                fr.chartOutput.Series[0].Points.AddXY(i + 1, Wave_1[i]);
                chartOutput.Series[1].Points.AddXY(i + 1, Wave_2[i]);
                fr.chartOutput.Series[1].Points.AddXY(i + 1, Wave_2[i]);
                chartOutput.Series[2].Points.AddXY(i + 1, Sinewave[i]);
                fr.chartOutput.Series[2].Points.AddXY(i + 1, Sinewave[i]);
            }
        }
        void List_Clear()
        {
            chartOutput.Series[0].Points.Clear();
            chartOutput.Series[1].Points.Clear();
            chartOutput.Series[2].Points.Clear();
            chartOutput.Series[3].Points.Clear();
            chartOutput.Series[4].Points.Clear();
            Wave_1 = new List<double>();
            Wave_2 = new List<double>();
            Sinewave = new List<double>();
            Sinewave_FIR = new List<double>();
            Sinewave_IIR = new List<double>();
            fr = new Form2();
            dataGridViewOtput.Rows.Clear();
        }

        private void ChartOutput_Click(object sender, EventArgs e)
        {
            fr.Show();
        }
    }
}
