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
    public partial class admin商主 : Form
    {
        public admin商主()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin2_Load(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void Table()//读取数据
        {
            dataGridView1.Rows.Clear();
            Link da=new Link();
            string sql = "select * from Goods";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3, a4, a5, a6, a7;
        
            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                a6 = dc[6].ToString();
                a6=a6.Remove(9);
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            da.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin商添 admin = new admin商添();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from Goods where 商品编号='{id}'";
                    Link da = new Link();
                    if (da.Excute(sql)>0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败"+sql);
                    }
                    da.Close();
                }
            }
            catch
            {
                MessageBox.Show("选择要删除的商品", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string a7 = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string a8 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                admin商改 admin=new admin商改(a1,a2,a3,a4,a5,a6,a7,a8);
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableId();
        }
        public void TableId()
        {
            dataGridView1.Rows.Clear();
            Link da = new Link();
            string sql = $"select * from Goods where 商品编号 ='{textBox1.Text}'";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3, a4, a5, a6, a7;

            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                a6 = dc[6].ToString();
                a6 = a6.Remove(9);
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            da.Close();
        }
        public void TableNa()
        {
            dataGridView1.Rows.Clear();
            Link da = new Link();
            string sql = $"select * from Goods where 商品名称 like '%{textBox2.Text}%'";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3, a4, a5, a6, a7;

            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a5 = dc[5].ToString();
                a6 = dc[6].ToString();
                a6 = a6.Remove(9);
                a7 = dc[7].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5, a6, a7 };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            da.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            TableNa();
        }
    }
}
