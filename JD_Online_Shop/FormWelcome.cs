using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JD_Online_Shop_Dal.NetWork;

namespace JD_Online_Shop {
    public partial class FormWelcome : Form {
        public bool Pass { get; set; }
        public FormWelcome () {
            InitializeComponent();
            Pass = false;
        }

        private void btnAdminLogin_Click (object sender, EventArgs e) {
            panel2.Visible = true;
        }

        private void btnQuit_Click (object sender, EventArgs e) {
            MessageBox.Show("即将退出！");
            Application.Exit();
        }

        private void btnRegister_Click (object sender, EventArgs e) {
            FormRegister frmRegister = new FormRegister();
            this.Hide();
            frmRegister.ShowDialog();
            if (frmRegister.Pass) {
                frmRegister.Hide();
                this.Show();
            }
        }

        private void btnForgetPwd_Click (object sender, EventArgs e) {

        }

        private void btnUserLogin_Click (object sender, EventArgs e) {
            Pass = true;
            this.Hide();
        }

        private void btnAdminCancel_Click (object sender, EventArgs e) {
            panel2.Visible = false;
        }

        private void btnTest_Click (object sender, EventArgs e) {
            Spider sp = new Spider();
            sp.start();
            //sp.test111();
            //sp.start2();
            if (sp.Pass) {
                MessageBox.Show("初始化完成！！");
            }
        }
    }
}
