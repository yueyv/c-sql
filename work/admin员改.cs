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
    public partial class admin员改 : Form
    {
        string ID = "";
        public admin员改()
        {
            InitializeComponent();
        }
        public admin员改(string id, string shuxing, string name, string price, string size, string factory, string birth, string tip)
        {
            InitializeComponent();
            ID = id;
            textBox1.Text = id;
            textBox2.Text = shuxing;
            textBox3.Text = name;
            textBox4.Text = price;
            textBox5.Text = size;
            textBox6.Text = factory;
            textBox7.Text = birth;
            textBox8.Text = tip;
        }
        private void admin32_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Employees set 员工编号='{textBox1.Text}',姓名='{textBox2.Text}',性别='{textBox3.Text}',年龄={textBox4.Text},电话='{textBox5.Text}' ,住址='{textBox6.Text}',职位='{textBox7.Text}',密码='{textBox8.Text}' where	员工编号='{ID}'";
            Link da = new Link();
            if (da.Excute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
