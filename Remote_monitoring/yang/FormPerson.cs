using dataProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerSocketManage;
using ClientManage;

namespace Remote_monitoring.yang
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            string[] userarr = Remote_Server.GetClients();
            for(int i =0;i<userarr.Length;i++)
            {
                listBox1.Items.Add(userarr[i]);
            }
           
          
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            byte[] b = dataProcess.dataProcessing.ReadPic();
            MemoryStream stream = new MemoryStream(b);
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client.GetScreen(listBox1.SelectedItem.ToString());
            Client.GetProcess(listBox1.SelectedItem.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.lockScreen(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.unlockScreen(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client.shutdown(listBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client.reboot(listBox1.SelectedItem.ToString());
        }
    }


       
    }

