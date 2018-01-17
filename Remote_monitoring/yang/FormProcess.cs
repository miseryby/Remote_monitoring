
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_monitoring.yang
{
   
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, System.EventArgs e)
        {
            MyItem item1 = new MyItem();
            item1.id = "001";
            item1.name = "天下";
            

            MyItem item2 = new MyItem();
            item2.id = "002";
            item2.name = "天上";
           


            MyItem item3 = new MyItem();
            item3.id = "003";
            item3.name = "地下";
           

            MyItem item4 = new MyItem();
            item4.id = "004";
            item4.name = "地上";
          

        }
    }
    public class MyItem : object
    {
        public string name;
        public string id;
        public override string ToString()
        {
            // TODO:  添加 MyItem.ToString 实现
            return name;
        }
    }
}
