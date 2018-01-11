using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_monitoring.yang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int i = 0;



        private void 查询用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yang.FormUserShow formUserShow = new FormUserShow();
            formUserShow.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               //i++，实现第i张；
                
                i++;

                this.pictureBox1.Image = imageList1.Images[i];

                //当i=3时，i变为0，然后重新开始；

                if (i == 3)

                {

                    i = 0;

                }
            
        }

        private void 显示帮助信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
    }
    
}
