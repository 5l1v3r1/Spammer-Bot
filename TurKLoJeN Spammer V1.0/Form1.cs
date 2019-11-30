using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurKLoJeN_Spammer_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TurKLoJeN Tarafından Kodlanmıştır Versiyon 1.0");
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("TurKLoJeN Tarafından Kodlanmıştır Versiyon 1.0");
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void ambiance_Button_21_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
