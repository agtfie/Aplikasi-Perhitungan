namespace Aplikasi_Perhitungan.GUI
{
    partial class FormTimer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDetik;
        private System.Windows.Forms.Label labelMenit;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timerCountdown;
        public System.Windows.Forms.TextBox textBoxMenit;
        public System.Windows.Forms.TextBox textBoxDetik;
        public System.Windows.Forms.Button buttonReset2;
        public System.Windows.Forms.Button buttonStop2;
        public System.Windows.Forms.Button buttonStart2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxMenit = new System.Windows.Forms.TextBox();
            this.textBoxDetik = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonReset2 = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.labelDetik = new System.Windows.Forms.Label();
            this.labelMenit = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // textBoxMenit
            this.textBoxMenit.Location = new System.Drawing.Point(64, 91);
            this.textBoxMenit.Name = "textBoxMenit";
            this.textBoxMenit.Size = new System.Drawing.Size(96, 20);
            this.textBoxMenit.TabIndex = 5;
            this.textBoxMenit.Text = "0";
            this.textBoxMenit.TextChanged += new System.EventHandler(this.textBoxMenit_TextChanged);

            // textBoxDetik
            this.textBoxDetik.Location = new System.Drawing.Point(330, 91);
            this.textBoxDetik.Name = "textBoxDetik";
            this.textBoxDetik.Size = new System.Drawing.Size(96, 20);
            this.textBoxDetik.TabIndex = 4;
            this.textBoxDetik.Text = "0";
            this.textBoxDetik.TextChanged += new System.EventHandler(this.textBoxDetik_TextChanged);

            // labelCount
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold);
            this.labelCount.Location = new System.Drawing.Point(178, 150);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 43);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "00:00";

            // buttonReset2
            this.buttonReset2.Location = new System.Drawing.Point(292, 216);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(75, 31);
            this.buttonReset2.TabIndex = 0;
            this.buttonReset2.Text = "Reset";

            // buttonStop2
            this.buttonStop2.Location = new System.Drawing.Point(185, 216);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(75, 31);
            this.buttonStop2.TabIndex = 1;
            this.buttonStop2.Text = "Stop";

            // buttonStart2
            this.buttonStart2.Location = new System.Drawing.Point(79, 216);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(75, 31);
            this.buttonStart2.TabIndex = 2;
            this.buttonStart2.Text = "Start";

            // labelDetik
            this.labelDetik.AutoSize = true;
            this.labelDetik.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelDetik.Location = new System.Drawing.Point(279, 94);
            this.labelDetik.Name = "labelDetik";
            this.labelDetik.Size = new System.Drawing.Size(45, 17);
            this.labelDetik.TabIndex = 6;
            this.labelDetik.Text = "Detik:";

            // labelMenit
            this.labelMenit.AutoSize = true;
            this.labelMenit.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelMenit.Location = new System.Drawing.Point(12, 94);
            this.labelMenit.Name = "labelMenit";
            this.labelMenit.Size = new System.Drawing.Size(46, 17);
            this.labelMenit.TabIndex = 7;
            this.labelMenit.Text = "Menit:";

            // labelTimer
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelTimer.Location = new System.Drawing.Point(178, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(108, 42);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "TIMER";

            // timerCountdown
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick_1);

            // FormTimer
            this.ClientSize = new System.Drawing.Size(451, 308);
            this.Controls.Add(this.buttonReset2);
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxDetik);
            this.Controls.Add(this.textBoxMenit);
            this.Controls.Add(this.labelDetik);
            this.Controls.Add(this.labelMenit);
            this.Controls.Add(this.labelTimer);
            this.Name = "FormTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
