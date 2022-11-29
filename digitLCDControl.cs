using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace digitLCD
{
    public partial class digitLCDControl : UserControl
    {
        public digitLCDControl()
        {
            InitializeComponent();
        }

        public int i;

        //orizoantalBarLCD
        //verticlaBarLCD
        //       sus
        // 1sus         2sus
        //       mid
        // 1jos         2jos
        //       jos

        public void setValue(int k)
        {
            i = k;
        }

        public void setColorMatrix()
        {
            
            if (i == 0)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(0);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(1);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 1)
            {
                this.orizoantalBarLCD1sus.setI(0);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(0);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(0);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(0);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 2)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(0);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(1);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(0);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 3)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(0);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 4)
            {
                this.orizoantalBarLCD1sus.setI(0);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(0);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 5)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(0);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 6)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(1);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(0);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 7)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(0);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(0);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(0);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 8)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(1);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }
            else if (i == 9)
            {
                this.orizoantalBarLCD1sus.setI(1);
                this.orizoantalBarLCD1sus.setColor();
                this.orizoantalBarLCD3mid.setI(1);
                this.orizoantalBarLCD3mid.setColor();
                this.orizoantalBarLCD2jos.setI(1);
                this.orizoantalBarLCD2jos.setColor();
                this.verticlaBarLCD1s.setI(1);
                this.verticlaBarLCD1s.setColor();
                this.verticlaBarLCD1j.setI(0);
                this.verticlaBarLCD1j.setColor();
                this.verticlaBarLCD2s.setI(1);
                this.verticlaBarLCD2s.setColor();
                this.verticlaBarLCD2j.setI(1);
                this.verticlaBarLCD2j.setColor();

            }

        }

        private void digitLCDControl_Load(object sender, EventArgs e)
        {

        }
    }
}
