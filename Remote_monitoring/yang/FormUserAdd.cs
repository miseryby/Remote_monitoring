using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Remote_monitoring.yang
{
    public partial class FormUserAdd : Form
    {
        public FormUserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //确定输入的界面
            String nname = textBox1.Text;
            String npassword = textBox2.Text;
            String nconfirmword = textBox3.Text;
            bool mana = radioButton1.Checked;
            
            if(!npassword.Equals(nconfirmword))
            {
                MessageBox.Show("你输入的确认密码与密码不一致，请重新输入");
                textBox2.Clear();
                textBox3.Clear();
            }
            string constr = "server=.;database=management;integrated security=SSPI";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from  Table_1", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            listBox1.DataSource = ds.Tables[0].DefaultView;
            listBox2.DataSource = ds.Tables[0].DefaultView;
            listBox1.DisplayMember = "Mname";
            listBox2.DisplayMember = "Priviledge";
            connection.Close();
            string stradd = "INSERT INTO Table_1('"+nname+"','"+npassword+"',"+mana+")";
            SqlCommand sqlCommand = new SqlCommand(stradd)
            {
                Connection = connection
            };
           // sqlCommand.ExecuteNonQuery();
            MessageBox.Show("新用户添加成功");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yang.FormUserShow userShow = new FormUserShow();
            this.Hide();
            userShow.Show();
            
        }
    }
}
