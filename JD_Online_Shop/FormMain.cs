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
using System.IO;

namespace JD_Online_Shop {
    public partial class FormMain : Form {
        private CUser user;
        public string UserEmail{ get; set; }
        public string UserName { get; set; }
        public FormMain () {
            InitializeComponent();
        }

        private void FormMain_Load (object sender, EventArgs e) {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            if (frmLogin.Pass) {
                //MessageBox.Show(frmLogin.UserEmail + " + " + frmLogin.UserName);
                UserEmail = frmLogin.UserEmail;
                UserName = frmLogin.UserName;
                frmLogin.Hide();
                this.Show();
                this.lblUserName.Text = UserName;
                user = new CUser(UserEmail, CUser.doSome.initialization);
                MemoryStream ms = new MemoryStream(user.getUserPic(user.CUserEmail));
                picUser.Image = Image.FromStream(ms);
            }
            else {
                MessageBox.Show("登录异常，系统即将关闭！！");
                Application.Exit();
            }
        }

        private void picUserSeting_Click (object sender, EventArgs e) {
            FormInfoSeting frmInfoSeting = new FormInfoSeting();
            frmInfoSeting.UserEmail = UserEmail;
            frmInfoSeting.UserName = UserName;
            frmInfoSeting.ShowDialog();
            this.lblUserName.Text = UserName;
            user = new CUser(UserEmail, CUser.doSome.initialization);
            MemoryStream ms = new MemoryStream(user.getUserPic(user.CUserEmail));
            picUser.Image = Image.FromStream(ms);
        }

        private void pictureBox13_Click (object sender, EventArgs e) {
            FormRecharge frmRecharge = new FormRecharge();
            frmRecharge.UserEmail = UserEmail;
            frmRecharge.UserName = UserName;
            frmRecharge.ShowDialog();
        }
    }
}
