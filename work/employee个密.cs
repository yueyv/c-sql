using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class employee个密 : Form
    {
        string id, p_c;
        public employee个密()
        {
            InitializeComponent();
        }
        public employee个密(string ID,string code)
        {
            InitializeComponent();
            id = ID;
            p_c = code;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != p_c)
            {
                MessageBox.Show("原密码错误！");
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("新密码和确认密码不一致！");
                textBox2.Text = textBox3.Text = "";
            }
            else
            {
                string sql = $"update Employees set 密码='{textBox2.Text}'  where 员工编号='{id}'";
                Link da = new Link();
                if (da.Excute(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        private void employee个密_Load(object sender, EventArgs e)
        {

        }
    }
}
