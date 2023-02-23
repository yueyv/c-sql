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
    public partial class admin单主 : Form
    {
        public admin单主()
        {
            InitializeComponent();
            Table();
        }
        public void Table()//读取数据
        {
            dataGridView1.Rows.Clear();
            Link da = new Link();
            string sql = $"select * from Trade";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3, a4, a5;

            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a4 = a4.Remove(9);
                a5 = dc[5].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5};
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            da.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableId();
        }
        public void TableId()
        {
            dataGridView1.Rows.Clear();
            Link da = new Link();
            string sql = $"select * from Trade where 流水单号 ='{textBox1.Text}'";
            IDataReader dc = da.read(sql);
            string a0, a1, a2, a3, a4, a5;

            while (dc.Read())
            {
                a0 = dc[0].ToString();
                a1 = dc[1].ToString();
                a2 = dc[2].ToString();
                a3 = dc[3].ToString();
                a4 = dc[4].ToString();
                a4 = a4.Remove(9);
                a5 = dc[5].ToString();
                string[] table = { a0, a1, a2, a3, a4, a5 };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            da.Close();
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
                admin单改 admin = new admin单改(a1, a2, a3, a4, a5, a6);
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

        private void admin单主_Load(object sender, EventArgs e)
        {

        }
    }
}
