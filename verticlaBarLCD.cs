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
    public partial class verticlaBarLCD : UserControl
    {
        public verticlaBarLCD()
        {
            InitializeComponent();
        }

        public int i = 0;
        public void setI(int k)
        {
            i = k;
        }
        public void setColor()
        {
            if (i == 0)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Red;
            }
        }

        private void verticlaBarLCD_Load(object sender, EventArgs e)
        {

        }
    }
}
