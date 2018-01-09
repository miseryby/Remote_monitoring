namespace Remote_monitoring
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPw = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(50, 218);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 35);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "登陆";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(194, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 35);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(47, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "用户名";
            // 
            // labelPw
            // 
            this.labelPw.AutoSize = true;
            this.labelPw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPw.Location = new System.Drawing.Point(47, 143);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(39, 20);
            this.labelPw.TabIndex = 4;
            this.labelPw.Text = "密码";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(141, 68);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(135, 27);
            this.textBox.TabIndex = 5;
            // 
            // textBoxPw
            // 
            this.textBoxPw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPw.Location = new System.Drawing.Point(141, 143);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.Size = new System.Drawing.Size(135, 27);
            this.textBoxPw.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "远程监控系统管理员登陆界面";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPw);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Label label1;
    }
}

