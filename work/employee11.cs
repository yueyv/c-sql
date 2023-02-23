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
    public partial class employee11 : Form
    {
        public employee11()
        {
            InitializeComponent();
            count();
        }
        private void count()
        {
            Link da = new Link();
            string sql = $"select max(流水单号)+1 as x from Trade";
            IDataReader dc = da.read(sql);
            if (dc.Read())
            {
                label7.Text = dc["x"].ToString();
            }

            label8.Text=DateTime.Now.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != "")
            {
                Link da = new Link();
                string sql = $"insert into Trade values('{label7.Text}','{textBox2.Text}','{textBox3.Text}'," +
                    $"{textBox4.Text},'{label8.Text}',{textBox6.Text})";
                int n = da.Excute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                    Link da2 = new Link();
                    string sql2 = $"update Goods set 库存量=库存量-'{textBox4.Text}' where 商品编号='{textBox3.Text}'";
                    int n2 = da2.Excute(sql2);
                    count();
                    textBox2.Text = textBox3.Text = textBox4.Text = textBox6.Text = "";
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                MessageBox.Show("有非必要空值");
            }
      
        }

        private void employee11_Load(object sender, EventArgs e)
        {
            count();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
