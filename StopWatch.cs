using System;
using System.Windows.Forms;

namespace Aplikasi_Perhitungan.GUI
{
    public partial class StopWatch : Form
    {
        private double elapsedTime = 0.0; 

        public StopWatch()
        {
            InitializeComponent();
            timer1.Interval = 10; 
            timer1.Tick += new EventHandler(timer1_Tick); 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            elapsedTime = 0.0; 
            labeltime.Text = elapsedTime.ToString("F2"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.01; 
            labeltime.Text = elapsedTime.ToString("F2");
        }
    }
}
