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
    
    public partial class admin单改 : Form
    {
        string ID;
        public admin单改()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Trade set 客户编号='{textBox2.Text}',商品编号='{textBox3.Text}',商品数量={textBox4.Text},购买时间='{textBox5.Text}' ,金额={textBox6.Text} where	流水单号='{ID}'";
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
        public admin单改(string id, string shuxing, string name, string price, string size, string factory)
        {
            InitializeComponent();
            ID = id;
            textBox2.Text = shuxing;
            textBox3.Text = name;
            textBox4.Text = price;
            textBox5.Text = size;
            textBox6.Text = factory;

        }

        private void admin单改_Load(object sender, EventArgs e)
        {

        }
    }
}
