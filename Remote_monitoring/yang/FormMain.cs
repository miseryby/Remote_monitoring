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
      

    private void 查询用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yang.FormUserShow formUserShow = new FormUserShow();
            formUserShow.Show();
            
        }

    private void 显示帮助信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "系统时间:" + DateTime.Now.ToString();
        }

        private void 桌面监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            yang.FormPerson formPerson = new FormPerson();
            formPerson.FormBorderStyle = FormBorderStyle.None;
            formPerson.TopLevel =false; //指示子窗体非顶级窗体
            this.panel1.Controls.Add(formPerson);//将子窗体载入panel
            formPerson.Show();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
             yang.FormUserShow formUserShow = new FormUserShow();
            formUserShow.FormBorderStyle = FormBorderStyle.None;
            formUserShow.TopLevel =false; //指示子窗体非顶级窗体
            this.panel1.Controls.Add(formUserShow);//将子窗体载入panel
            formUserShow.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
             yang.FormProcess formProcess = new FormProcess();
            formProcess.FormBorderStyle = FormBorderStyle.None;
            formProcess.TopLevel =false; //指示子窗体非顶级窗体
            this.panel1.Controls.Add(formProcess);//将子窗体载入panel
            formProcess.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("是否要退出程序?", "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                Application.ExitThread();// 强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题；

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer2.Start();
            toolStripStatusLabel2.Text = "系统时间:" + DateTime.Now.ToString();
            
            toolStripStatusLabel3.Text = "开发小组:516";
            this.新增用户ToolStripMenuItem.Enabled = false;
            this.更新用户ToolStripMenuItem.Enabled = false;
            this.删除用户ToolStripMenuItem.Enabled = false;
            this.锁屏ToolStripMenuItem.Enabled = false;
            this.解锁ToolStripMenuItem.Enabled = false;
            this.关机ToolStripMenuItem.Enabled = false;
            this.重启ToolStripMenuItem.Enabled = false;
        }

        private void 退出当前程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出程序?", "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                Application.ExitThread();// 强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题；

            }
        }

        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
    
}
