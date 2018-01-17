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
                byte[] b =dataProcess.dataProcessing.ReadPic();
                MemoryStream stream = new MemoryStream(b);
                pictureBox1.Image = Image.FromStream(stream);
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            byte[] b = dataProcess.dataProcessing.ReadPic();
            MemoryStream stream = new MemoryStream(b);
            pictureBox1.Image = Image.FromStream(stream);
        }
    }


       
    }

