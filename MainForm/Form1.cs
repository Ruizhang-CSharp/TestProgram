using ModelSolutionS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = textBox1.Text.Trim();
            string uPwd = textBox2.Text.Trim();
            if(string.IsNullOrEmpty(uName))
            {
                MessageBox.Show( "账号不能为空", "登陆系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(uPwd))
            {
                MessageBox.Show( "密码不能为空", "登陆系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            UserBLL userBLL = new UserBLL();
            switch (userBLL.LoginSystem(uName, uPwd))
            {
                case 0 : MessageBox.Show( "用户不存在", "登陆系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1 : MessageBox.Show( "用户密码正确", "登陆系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2 : MessageBox.Show( "密码错误", "登陆系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
