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
    public partial class employee1 : Form
    {
        string ID;
        public employee1()
        {
            InitializeComponent();
        }
        public employee1(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            admin客主 admin = new admin客主();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           employee11 em = new employee11();
            this.Hide();
            em.ShowDialog();
            this.Show();
        }

        private void employee1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee个人 em = new employee个人(ID);
            this.Hide();
            em.ShowDialog();
            this.Show();
        }
    }
}
