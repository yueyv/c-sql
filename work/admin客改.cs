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
    public partial class admin客改 : Form
    {
  
        public admin客改()
        {
            InitializeComponent();

        }
        public admin客改(string id, string name, string sex, string tele,string vip,string beizhu)
        {
            InitializeComponent();
            label7.Text = id;
            textBox2.Text = name;
            if (sex == "男")
                male.Checked = true;
            else
                female.Checked = true;
            if (vip == "VIP")
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
            textBox4.Text = tele;
            textBox5.Text = beizhu;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
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
                string sql = $"update Customers set 姓名='{textBox2.Text}',性别='{sex}',电话='{textBox4.Text}',VIP='{vip}',备注='{textBox5.Text}' where 客户编号='{label7.Text}'";
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin客改_Load(object sender, EventArgs e)
        {

        }
    }
}
