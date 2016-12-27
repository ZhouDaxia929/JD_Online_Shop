using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JD_Online_Shop_Bll;

namespace JD_Online_Shop {
    public partial class FormLogin : Form {
        private CUser user;
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool Pass { get; set; }
        FormWelcome frmWelcome = new FormWelcome();
        public FormLogin () {
            InitializeComponent();
            Pass = false;
        }

        private void FormLogin_Load (object sender, EventArgs e) {
            this.Hide();
            frmWelcome.ShowDialog();
            if (frmWelcome.Pass) {
                frmWelcome.Hide();
                this.Show();
            }
            else {
                MessageBox.Show("登录异常，系统即将关闭！！");
                Application.Exit();
            }
        }

        private void btnOK_Click (object sender, EventArgs e) {
            CUser user = new CUser(txtEmail.Text, CUser.doSome.initialization);
            UserEmail = txtEmail.Text;
            string name = "";
            if(user.Login(txtPwd.Text, ref name)) {
                UserName = name;
                Pass = true;
                this.Hide();
            }
            else {
                MessageBox.Show("用户名或密码错误！请重新填写！！");
                txtEmail.Focus();
            }
        }

        private void btnCancel_Click (object sender, EventArgs e) {
            this.Hide();
            frmWelcome.Show();
        }
    }
}
