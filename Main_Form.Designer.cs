namespace Aplikasi_Perhitungan.GUI
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.PilihMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_stopwatch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_timer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PilihMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";

            // PilihMenu
            this.PilihMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_stopwatch,
            this.toolStripMenuItem1,
            this.submenu_timer});
            this.PilihMenu.Name = "PilihMenu";
            this.PilihMenu.Size = new System.Drawing.Size(76, 20);
            this.PilihMenu.Text = "&Pilih Menu";
            this.PilihMenu.Click += new System.EventHandler(this.PilihMenu_Click);

            // submenu_stopwatch
            this.submenu_stopwatch.Name = "submenu_stopwatch";
            this.submenu_stopwatch.Size = new System.Drawing.Size(180, 22);
            this.submenu_stopwatch.Text = "&Stop Watch";
            this.submenu_stopwatch.Click += new System.EventHandler(this.submenu_stopwatch_Click);

            // toolStripMenuItem1
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);

            // submenu_timer
            this.submenu_timer.Name = "submenu_timer";
            this.submenu_timer.Size = new System.Drawing.Size(180, 22);
            this.submenu_timer.Text = "&Timer";
            this.submenu_timer.Click += new System.EventHandler(this.submenu_timer_Click);

            // Main_Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem PilihMenu;
        public System.Windows.Forms.ToolStripMenuItem submenu_stopwatch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_timer;
    }
}



