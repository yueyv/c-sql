namespace work
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.商品管理 = new System.Windows.Forms.Button();
            this.员工管理 = new System.Windows.Forms.Button();
            this.流水管理 = new System.Windows.Forms.Button();
            this.客户管理 = new System.Windows.Forms.Button();
            this.退出登录 = new System.Windows.Forms.Button();
            this.个人信息 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "登录成功！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 82);
            this.label2.TabIndex = 2;
            // 
            // 商品管理
            // 
            this.商品管理.Location = new System.Drawing.Point(274, 63);
            this.商品管理.Name = "商品管理";
            this.商品管理.Size = new System.Drawing.Size(150, 70);
            this.商品管理.TabIndex = 3;
            this.商品管理.Text = "商品管理";
            this.商品管理.UseVisualStyleBackColor = true;
            this.商品管理.Click += new System.EventHandler(this.商品管理_Click);
            // 
            // 员工管理
            // 
            this.员工管理.Location = new System.Drawing.Point(625, 63);
            this.员工管理.Name = "员工管理";
            this.员工管理.Size = new System.Drawing.Size(150, 70);
            this.员工管理.TabIndex = 4;
            this.员工管理.Text = "员工管理";
            this.员工管理.UseVisualStyleBackColor = true;
            this.员工管理.Click += new System.EventHandler(this.员工管理_Click);
            // 
            // 流水管理
            // 
            this.流水管理.Location = new System.Drawing.Point(274, 232);
            this.流水管理.Name = "流水管理";
            this.流水管理.Size = new System.Drawing.Size(150, 70);
            this.流水管理.TabIndex = 5;
            this.流水管理.Text = "流水管理";
            this.流水管理.UseVisualStyleBackColor = true;
            this.流水管理.Click += new System.EventHandler(this.流水管理_Click);
            // 
            // 客户管理
            // 
            this.客户管理.Location = new System.Drawing.Point(625, 232);
            this.客户管理.Name = "客户管理";
            this.客户管理.Size = new System.Drawing.Size(150, 70);
            this.客户管理.TabIndex = 6;
            this.客户管理.Text = "客户管理";
            this.客户管理.UseVisualStyleBackColor = true;
            this.客户管理.Click += new System.EventHandler(this.客户管理_Click);
            // 
            // 退出登录
            // 
            this.退出登录.Location = new System.Drawing.Point(625, 417);
            this.退出登录.Name = "退出登录";
            this.退出登录.Size = new System.Drawing.Size(150, 70);
            this.退出登录.TabIndex = 7;
            this.退出登录.Text = "退出登录";
            this.退出登录.UseVisualStyleBackColor = true;
            this.退出登录.Click += new System.EventHandler(this.退出登录_Click);
            // 
            // 个人信息
            // 
            this.个人信息.Location = new System.Drawing.Point(274, 417);
            this.个人信息.Name = "个人信息";
            this.个人信息.Size = new System.Drawing.Size(150, 70);
            this.个人信息.TabIndex = 8;
            this.个人信息.Text = "个人信息";
            this.个人信息.UseVisualStyleBackColor = true;
            this.个人信息.Click += new System.EventHandler(this.个人信息_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.个人信息);
            this.Controls.Add(this.退出登录);
            this.Controls.Add(this.客户管理);
            this.Controls.Add(this.流水管理);
            this.Controls.Add(this.员工管理);
            this.Controls.Add(this.商品管理);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.admin1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 商品管理;
        private System.Windows.Forms.Button 员工管理;
        private System.Windows.Forms.Button 流水管理;
        private System.Windows.Forms.Button 客户管理;
        private System.Windows.Forms.Button 退出登录;
        private System.Windows.Forms.Button 个人信息;
        private System.Windows.Forms.Label label3;
    }
}