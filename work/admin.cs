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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (timer_Tick);
            timer.Enabled = true;
            void timer_Tick(object sender, EventArgs e)
            {
                label1.Visible = false;
                timer.Tick -= (timer_Tick);
                timer.Stop();
            }
        }
        public admin(string id)
        {
            InitializeComponent();
            label3.Text = id;
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (timer_Tick);
            timer.Enabled = true;
            void timer_Tick(object sender, EventArgs e)
            {
                label1.Visible = false;
                timer.Tick -= (timer_Tick);
                timer.Stop();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void 商品管理_Click(object sender, EventArgs e)
        {
            admin商主 admin = new admin商主();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 流水管理_Click(object sender, EventArgs e)
        {
            admin单主 admin = new admin单主();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 员工管理_Click(object sender, EventArgs e)
        {
            admin员主 admin = new admin员主();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 客户管理_Click(object sender, EventArgs e)
        {
            admin客主 admin = new admin客主();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 退出登录_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 个人信息_Click(object sender, EventArgs e)
        {
            Admin个人 admin = new Admin个人(label3.Text);
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
