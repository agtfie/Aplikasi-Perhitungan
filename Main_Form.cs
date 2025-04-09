using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perhitungan.GUI
{
    public partial class Main_Form : Form
    {
        StopWatch stw;
        FormTimer TimerForm;
        void stw_FormClosed(Object sender, FormClosedEventArgs e)
        {
            stw = null;
        }
        void TimerForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            TimerForm = null;
        }

        public Main_Form()
        {
            InitializeComponent();
        }
        private void PilihMenu_Click(object sender, EventArgs e)
        {

        }

        private void submenu_stopwatch_Click(object sender, EventArgs e)
        {
            if (stw==null)
            {
                stw = new StopWatch();
                stw.MdiParent = this;

                stw.FormClosed += new FormClosedEventHandler(stw_FormClosed);
                stw.Show();
            }
            else 
            {
                stw.Activate();
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void submenu_timer_Click(object sender, EventArgs e)
        {
            if (TimerForm == null)
            {
                TimerForm = new FormTimer();
                TimerForm.MdiParent = this;

                TimerForm.FormClosed += new FormClosedEventHandler(TimerForm_FormClosed);
                TimerForm.Show();
            }
            else
            {
                TimerForm.Activate();
            }
        }
    }
}
