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
    public partial class admin客添 : Form
    {
        public admin客添()
        {
            InitializeComponent();
            count();
        }
        private void count()
        {
            Link da = new Link();
            string sql = $"select max(客户编号)+1 as x from Customers";
            IDataReader dc = da.read(sql);
            if (dc.Read())
            {
                textBox1.Text = dc["x"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != ""&& textBox4.Text != "")
            {
                Link da = new Link();
                string sex;
                bool vip;
                if (male.Checked == true)
                    sex = "男";
                else
                    sex = "女";
                if (checkBox1.Checked == true)
                    vip = true;
                else
                    vip = false;
                if (textBox5.Text == "")
                    textBox5.Text = null;
                string sql = $"insert into Customers values('{textBox1.Text}','{textBox2.Text}','{sex}','{textBox4.Text}','{vip}','{textBox5.Text}')";                
                if (da.Excute(sql) > 0)
                {
                    count();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                MessageBox.Show("客户信息的主要信息不能为空！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin客添_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
