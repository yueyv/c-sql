using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace work
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("账号密码均不能为空！");
            }
        }
        public void login()
        {
            if (radioButtonUser.Checked == true)
            {
                Link da= new Link();
                string sql = "select * from Employees where 员工编号='" + textBox1.Text+"' and 密码='"+textBox2.Text+"'";
                IDataReader dc = da.read(sql);
                if (dc.Read())
                {
                    data.UID = dc["员工编号"].ToString();
                    data.UNAME = dc["姓名"].ToString();
                    employee1 em=new employee1(textBox1.Text);
                    this.Hide();
                    em.ShowDialog();
                    this.textBox2.Clear();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("账号或密码错误，登录失败！");
     
                }
            }
            if(radioButtonAdmin.Checked == true)
            {
                Link da = new Link();
                string sql = "select * from Admin where 管理员编号='" + textBox1.Text + "' and 密码='" + textBox2.Text + "'";
                IDataReader dc = da.read(sql);
                if (dc.Read())
                {
                    admin em = new admin(textBox1.Text);
                    this.Hide();
                    em.ShowDialog();
                    this.textBox2.Clear();
                    this.Show();
                
                }
                else
                {
                    MessageBox.Show("账号或密码错误，登录失败");
                }
                da.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }
    }
}
