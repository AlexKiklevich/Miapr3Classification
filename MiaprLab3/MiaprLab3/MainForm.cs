using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace MiaprLab3
{
    public partial class MainForm : Form
    {
        Graphics graph;
        double PC1, PC2;
        double p1 = 0, p2 = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void VerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (VerTrackBar.Maximum == VerTrackBar.Value)
            {
                VerOneLabel.Text = "1";
                VerTwoLabel.Text = "0";
            }
            if (VerTrackBar.Value == VerTrackBar.Minimum)
            {
                VerOneLabel.Text = "0";
                VerTwoLabel.Text = "1";
            }
            if (VerTrackBar.Maximum != VerTrackBar.Value && VerTrackBar.Value != VerTrackBar.Minimum)
            {
                VerOneLabel.Text = "0." + (VerTrackBar.Value).ToString();
                VerTwoLabel.Text = "0." + (VerTrackBar.Maximum - VerTrackBar.Value).ToString();
            }

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            graph = CoordinationPanel.CreateGraphics();
            Random rand = new Random();
            PC1 = double.Parse(VerOneLabel.Text);
            PC2 = double.Parse(VerTwoLabel.Text);
            int[] points1 = new int[1000];
            int[] points2 = new int[1000];
            double mu1 = 0;
            double mu2 = 0;
            double sigma1 = 0;
            double sigma2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                points1[i] = rand.Next(1, 466);
                points2[i] = rand.Next(1, 466);
                mu1 += points1[i] / 1000;
                mu2 += points2[i] / 1000;
            }
            for (int i = 0; i < 1000; i++)
            {
                sigma1 += Math.Sqrt(Math.Pow(points1[i] - mu1, 2) / 1000);
                sigma2 += Math.Sqrt(Math.Pow(points2[i] - mu2, 2) / 1000);
            }
            var resultFunc1 = new double[CoordinationPanel.Width];
            var resultFunc2 = new double[CoordinationPanel.Width];
            resultFunc1[0] = (Math.Exp(-0.5 * Math.Pow((0 - mu1) / sigma1, 2)) /
                   (sigma1 * Math.Sqrt(2 * Math.PI)) * PC1); ;
            resultFunc2[0] =
                    (Math.Exp(-0.5 * Math.Pow((-100 - mu2) / sigma2, 2)) /
                    (sigma2 * Math.Sqrt(2 * Math.PI)) * PC2);

            int D = 0;
            for (int x = 1; x < CoordinationPanel.Width; x++)
            {
                resultFunc1[x] =
                    (Math.Exp(-0.5 * Math.Pow((x - mu1) / sigma1, 2)) /
                    (sigma1 * Math.Sqrt(2 * Math.PI)) * PC1);

                resultFunc2[x] =
                    (Math.Exp(-0.5 * Math.Pow((x - 100 - mu2) / sigma2, 2)) /
                    (sigma2 * Math.Sqrt(2 * Math.PI)) * PC2);

                if (Math.Abs(resultFunc1[x] * 1000 - resultFunc2[x] * 1000) < 0.002)
                {
                    D = x;
                }

                graph.DrawLine(Pens.Blue,
                     new Point(x - 1, (CoordinationPanel.Height - (int)(resultFunc1[x - 1] * CoordinationPanel.Height * 400))),
                    new Point(x, (CoordinationPanel.Height - (int)(resultFunc1[x] * CoordinationPanel.Height * 400))));
                graph.DrawLine(Pens.Red,
                     new Point(x - 1, (CoordinationPanel.Height - (int)(resultFunc2[x - 1] * CoordinationPanel.Height * 400))),
                    new Point(x, (CoordinationPanel.Height - (int)(resultFunc2[x] * CoordinationPanel.Height * 400))));
            }
            double error1 = resultFunc2.Take((int)D).Sum();
            double error2;
            if (PC1 > PC2)
            {
                error2 = resultFunc2.Skip((int)D).Sum();
            }
            else
            {
                error2 = resultFunc1.Skip((int)D).Sum();
            }

            graph.DrawLine(Pens.Chartreuse, D, 0, D, pictureBox1.Height);
            graph.DrawLine(Pens.Black, 0, pictureBox1.Height - 1,
                pictureBox1.Width, pictureBox1.Height - 1);
            graphics.DrawLine(Pens.Black, pictureBox1.Width,
                pictureBox1.Height - 1, pictureBox1.Width - 15,
                pictureBox1.Height - 5);
            graphics.DrawLine(Pens.Black, 100, pictureBox1.Height - 1, 100, 0);
            graphics.DrawLine(Pens.Black, 100, 0, 95, 15);
            graphics.DrawLine(Pens.Black, 100, 0, 105, 15);

            error1TextBox.Text = error1.ToString();
            error2TextBox.Text = error2.ToString();
            sumErrorTextBox.Text = (error1 + error2).ToString();
            pictureBox1.Image = bitmap;
        }
    }
}
