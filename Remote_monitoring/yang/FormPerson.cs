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
            dataProcessing.
            string path = "C: \\Users\\~\\source\\repos\\Remote_monitoring\\Remote_monitoring\\yang\\image\\42.jpg";
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                byte[] b = new byte[file.Length];
                file.Read(b, 0, b.Length);
                MemoryStream stream = new MemoryStream(b);
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

       
    }
}
