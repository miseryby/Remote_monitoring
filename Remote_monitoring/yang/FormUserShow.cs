using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_monitoring.yang
{
    public partial class FormUserShow : Form
    {
        public FormUserShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yang.FormUserAdd formUserAdd = new FormUserAdd();
            formUserAdd.Show();
        }

        private void FormUserShow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“managementDataSet1.Table_1”中。您可以根据需要移动或删除它。
            this.table_1TableAdapter1.Fill(this.managementDataSet1.Table_1);
           
            string constr = "server=.;database=management;integrated security=SSPI";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from  Table_1", connection);
            
            connection.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
          
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
