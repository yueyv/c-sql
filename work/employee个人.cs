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
    public partial class employee个人 : Form
    {
        string code;
        public employee个人()
        {
            InitializeComponent();
        }
        public employee个人(string id)
        {
            InitializeComponent();
            label2.Text = id;
            load();
            个人信息查看ToolStripMenuItem_Click(null, null);
        }
        private void load()
        {
            Link da = new Link();
            string sql = $"select * from Employees where 员工编号='{label2.Text}'";
            IDataReader dc = da.read(sql);
            while (dc.Read())
            {
                textBox1.Text = label3.Text = dc[1].ToString();
                textBox2.Text = label4.Text = dc[2].ToString();
                textBox3.Text = label5.Text = dc[3].ToString();
                textBox4.Text = label6.Text = dc[4].ToString();
                textBox5.Text = label7.Text = dc[5].ToString();
                label8.Text = dc[6].ToString();
                code = dc[7].ToString();
            }
            dc.Close();
            da.Close();
        }
        private void employee个人_Load(object sender, EventArgs e)
        {
            load();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label_show(bool x)
        {
            label3.Visible = x;
            label4.Visible = x;
            label5.Visible = x;
            label6.Visible = x;
            label7.Visible = x;
        }
        private void textbox_show(bool x)
        {
            textBox1.Visible = x;
            textBox2.Visible = x;
            textBox3.Visible = x;
            textBox4.Visible = x;
            textBox5.Visible = x;
            button1.Visible = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Employees set 姓名='{textBox1.Text}',性别='{textBox2.Text}',年龄='{textBox3.Text}',电话='{textBox4.Text}',住址='{textBox5.Text}'  where 员工编号='{label2.Text}'";
            Link da = new Link();
            if (da.Excute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                个人信息查看ToolStripMenuItem_Click(null, null);
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void 个人信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load();
            label_show(true);
            textbox_show(false);

        }

        private void 信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_show(false);
            textbox_show(true);
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee个密 a = new employee个密(label2.Text,code);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
