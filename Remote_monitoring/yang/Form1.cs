﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_monitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            textBoxNa.ForeColor = Color.Blue;
            textBoxNa.BackColor = Color.Blue;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            textBoxPw.BackColor = Color.White;
            textBoxPw.ForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBoxNa.Text;
            String password = textBoxPw.Text;
            yang.FormMain formMain = new yang.FormMain();

            if (name=="admin" && password.Equals("admin"))
            {
            formMain.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("用户民或者密码错误");
             }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出程序");
            System.Environment.Exit(0);
        }
    }
}
