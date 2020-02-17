using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Pro
{
    public partial class Logo : Form
    {
       

        public Logo()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            timer1.Start();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .08;
            if (Opacity == 1)
                timer1.Stop();
        }
    }
}
