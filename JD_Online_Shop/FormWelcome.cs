using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Online_Shop {
    public partial class FormWelcome : Form {
        public FormWelcome () {
            InitializeComponent();
        }

        private void btnAdminLogin_Click (object sender, EventArgs e) {
            panel2.Visible = true;
        }

        private void btnQuit_Click (object sender, EventArgs e) {
            MessageBox.Show("即将退出！");
            Application.Exit();
        }

        private void btnRegister_Click (object sender, EventArgs e) {

        }

        private void btnForgetPwd_Click (object sender, EventArgs e) {

        }
    }
}
