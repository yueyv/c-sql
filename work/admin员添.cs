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
    public partial class admin员添 : Form
    {
        public admin员添()
        {
            InitializeComponent();
            count();
            textBox8.Text = "123456";
        }
        private void count()
        {
            Link da = new Link();
            string sql = $"select max(员工编号)+1 as x from Employees";
            IDataReader dc = da.read(sql);
            if (dc.Read())
            {
                textBox1.Text = dc["x"].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                Link da = new Link();
                string sql = $"insert into Employees values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}'," +
                    $"{textBox4.Text},'{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}')";
                int n = da.Excute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    count();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                MessageBox.Show("创建的员工信息应完整！");
            }
        }

        private void admin31_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
