using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmLoadForm : Form
    {
        public frmLoadForm()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        private int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 4;
            label2.Text = " " + i + "%";
            
            if(i == 100) {
                timer1.Stop();
            }
        }
    }
}
