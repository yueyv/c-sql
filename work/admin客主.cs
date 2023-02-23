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
    public partial class admin客主 : Form
    {
        public admin客主()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void admin5_Load(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Table()//读取数据
        {
            dataGridView1.Rows.Clear();
            Link data = new Link();
            string sql = "select * from Customers";
            IDataReader dc = data.read(sql);
            string a0, a1, a2, a3,a4,a5;

            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a4=a4.Replace("True", "VIP");
                a4 = a4.Replace("False", null);
                a5 = dc[5].ToString();
                string[] table = { a0, a1, a2, a3,a4,a5};
                dataGridView1.Rows.Add(table);
            }
            
            dc.Close();
            data.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除选中行的信息？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from Customers where 客户编号='{id}'";
                    Link da = new Link();
                    if (da.Excute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    da.Close();
                }
            }
            catch
            {
                MessageBox.Show("选择要删除的客户", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin客添 admin = new admin客添();
            this.Hide();
            admin.ShowDialog();
            this.Show();
            Table();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string a2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string a4 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string a5 = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string a6 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                admin客改 admin = new admin客改(a1, a2, a3, a4,a5,a6);
                this.Hide();
                admin.ShowDialog();
                this.Show();
                Table();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableId();
        }
        public void TableId()
        {
            Link da = new Link();
            string sql = $"select * from Customers where 电话 ='{textBox1.Text}'";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3,a4,a5;
            if (!dc.Read())
                MessageBox.Show("未查找到该客户！");
            else
            {
                dataGridView1.Rows.Clear();
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a4 = a4.Replace("True", "VIP");
                    a4 = a4.Replace("False", null);
                    a5 = dc[5].ToString();
                    string[] table = { a0, a1, a2, a3, a4, a5 };
                    dataGridView1.Rows.Add(table);
                }
            }
            dc.Close();
            da.Close();
        }
        public void TableNa()
        {
            dataGridView1.Rows.Clear();
            Link da = new Link();
            string sql = $"select * from Customers where 姓名 = '{textBox2.Text}'";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3,a4,a5;
            if (!dc.Read())
            {
                string sql1 = $"select * from Customers where 姓名 like '{textBox2.Text}%'";
                IDataReader dc1 = da.read(sql1);
                while (dc1.Read())
                {
                    a0 = dc1[0].ToString();
                    a1 = dc1[1].ToString();
                    a2 = dc1[2].ToString();
                    a3 = dc1[3].ToString();
                    a4 = dc1[4].ToString();
                    a4 = a4.Replace("True", "VIP");
                    a4 = a4.Replace("False", null);
                    a5 = dc1[5].ToString();
                    string[] table1 = { a0, a1, a2, a3, a4, a5 };
                    dataGridView1.Rows.Add(table1);
                }
                dc1.Close();
                MessageBox.Show("未查找到客户！以下客户是否为您所要查询的?");
            }
            else
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a4 = a4.Replace("True", "VIP");
                a4 = a4.Replace("False", null);
                a5 = dc[5].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
                while (dc.Read())
                {
                    a0 = dc[0].ToString();
                    a1 = dc[1].ToString();
                    a2 = dc[2].ToString();
                    a3 = dc[3].ToString();
                    a4 = dc[4].ToString();
                    a4 = a4.Replace("True", "VIP");
                    a4 = a4.Replace("False", null);
                    a5 = dc[5].ToString();
                    string[] table2 = { a0, a1, a2, a3, a4, a5 };
                    dataGridView1.Rows.Add(table2);
                }
            }
            dc.Close();
            
            da.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableNa();
        }
    }
}
