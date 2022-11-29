using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace digitLCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int runing = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            runing = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            int ora = dt.Hour;
            int d2ora = ora % 10;
            int d1ora = ora / 10;

            int min = dt.Minute;
            int d2min = min % 10;
            int d1min = min / 10;

            int sec = dt.Second;
            int d2sec = sec % 10;
            int d1sec = sec / 10;

            int ms = dt.Millisecond;
            int d3ms = ms % 10;
            ms = ms / 10;
            int d2ms = ms % 10;
            int d1ms = ms / 10;

            digitLCDControl1.setValue(d1ora);
            digitLCDControl1.setColorMatrix();
            digitLCDControl2.setValue(d2ora);
            digitLCDControl2.setColorMatrix();
            digitLCDControl3.setValue(d1min);
            digitLCDControl3.setColorMatrix();
            digitLCDControl4.setValue(d2min);
            digitLCDControl4.setColorMatrix();
            digitLCDControl5.setValue(d1sec);
            digitLCDControl5.setColorMatrix();
            digitLCDControl6.setValue(d2sec);
            digitLCDControl6.setColorMatrix();
            digitLCDControl7.setValue(d1ms);
            digitLCDControl7.setColorMatrix();
            digitLCDControl8.setValue(d2ms);
            digitLCDControl8.setColorMatrix();
            digitLCDControl9.setValue(d3ms);
            digitLCDControl9.setColorMatrix();
            Refresh();
        }

        public bool runStop()
        {

            if (runing == 1)
            {
                timer1.Stop();
                runing = 0;
                return true;
            }
            else
            {
                timer1.Start();
                runing = 1;
                return false;
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            runStop();
        }
    }
}
