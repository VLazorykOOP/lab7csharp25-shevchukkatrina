using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        private int state = 0; // 0 - red, 1 - yellow, 2 - green

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ініціалізація: тільки червоне світло
            SetLights(Color.Red, Color.Gray, Color.Gray);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int intervalSeconds = (int)numericUpDown1.Value;
            timer1.Interval = intervalSeconds * 1000; // мілісекунди
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0: // Red -> Yellow
                    SetLights(Color.Gray, Color.Yellow, Color.Gray);
                    state = 1;
                    break;
                case 1: // Yellow -> Green
                    SetLights(Color.Gray, Color.Gray, Color.Green);
                    state = 2;
                    break;
                case 2: // Green -> Red
                    SetLights(Color.Red, Color.Gray, Color.Gray);
                    state = 0;
                    break;
            }
        }

        private void SetLights(Color red, Color yellow, Color green)
        {
            panelRed.BackColor = red;
            panelYellow.BackColor = yellow;
            panelGreen.BackColor = green;
        }
    }
}
