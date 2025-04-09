using System;
using System.Windows.Forms;

namespace Aplikasi_Perhitungan.GUI
{
    public partial class FormTimer : Form
    {
        private int totalSeconds = 0;  

        public FormTimer()
        {
            InitializeComponent();

            buttonStart2.Click += buttonStart2_Click;
            buttonStop2.Click += buttonStop2_Click;
            buttonReset2.Click += buttonReset2_Click;

            timerCountdown.Interval = 1000;  // Interval 1 detik
            timerCountdown.Tick += timerCountdown_Tick_1;
        }

        // Menangani perubahan pada TextBox Menit
        private void textBoxMenit_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMenit.Text, out _))
            {
                textBoxMenit.Text = "0";  
            }
        }

        // Menangani perubahan pada TextBox Detik
        private void textBoxDetik_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDetik.Text, out _))
            {
                textBoxDetik.Text = "0"; 
            }
        }

        // Event handler untuk tombol Start
        private void buttonStart2_Click(object sender, EventArgs e)
        {
            int menit, detik;

            if (int.TryParse(textBoxMenit.Text, out menit) && int.TryParse(textBoxDetik.Text, out detik))
            {
                totalSeconds = (menit * 60) + detik;

                if (totalSeconds > 0)
                {
                    MessageBox.Show("Timer dimulai! Total detik: " + totalSeconds);
                    UpdateLabelTimer(); 
                    timerCountdown.Start(); 
                }
                else
                {
                    MessageBox.Show("Masukkan angka valid untuk menit dan detik.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Masukkan angka valid untuk menit dan detik.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler untuk tombol Stop
        private void buttonStop2_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();  
            MessageBox.Show("Timer dihentikan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler untuk tombol Reset
        private void buttonReset2_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop(); 
            totalSeconds = 0; 
            labelCount.Text = "00:00"; 
            textBoxMenit.Text = "0"; 
            textBoxDetik.Text = "0"; 
        }

        // Event handler untuk setiap tick timer
        private void timerCountdown_Tick_1(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--; 
                UpdateLabelTimer(); 
            }
            else
            {
                timerCountdown.Stop(); 
                MessageBox.Show("Waktu Habis!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Fungsi untuk memperbarui label timer
        private void UpdateLabelTimer()
        {
            int menit = totalSeconds / 60;  
            int detik = totalSeconds % 60;  
            labelCount.Text = menit.ToString("00") + ":" + detik.ToString("00");  
        }
    }
}
