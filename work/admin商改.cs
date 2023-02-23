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
    public partial class admin商改 : Form
    {
        string ID;
        public admin商改()
        {
            InitializeComponent();
        }
        public admin商改(string id, string shuxing,string name,string price,string size,string factory,string birth,string tip){
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
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Goods set 商品编号='{textBox1.Text}',商品属性='{textBox2.Text}',商品名称='{textBox3.Text}',商品单价='{textBox4.Text}',库存量={textBox5.Text} ,生产厂商='{textBox6.Text}',保质期='{textBox7.Text}',备注='{textBox8.Text}' where	商品编号='{ID}'";
            Link da=new Link();
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

        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                this.Close();
        }

        private void admin商改_Load(object sender, EventArgs e)
        {

        }
    }
}
