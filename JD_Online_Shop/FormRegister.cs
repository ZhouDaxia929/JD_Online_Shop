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
    public partial class FormRegister : Form {
        private string filename = string.Empty;
        private ValidCode validCode;
        public bool Pass { get; set; }
        public FormRegister () {
            InitializeComponent();
            Pass = false;
        }

        private void btnChoosePic_Click (object sender, EventArgs e) {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = this.openFileDialog1.FileName;
                picUser.Image = Image.FromFile(filename);
                this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }      
        }

        private void FormRegister_Load (object sender, EventArgs e) {
            validCode = new ValidCode(5, ValidCode.CodeType.Characters);
            picVerify.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            picVerify.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnOK_Click (object sender, EventArgs e) {
            if (txtEmail.Text.Equals(string.Empty)) {
                MessageBox.Show("账号不能为空！！");
                txtEmail.Focus();
            }
            if (txtName.Text.Equals(string.Empty)) {
                MessageBox.Show("昵称不能为空！！");
                txtName.Focus();
            }
            if (txtPwd.Text.Equals(string.Empty)) {
                MessageBox.Show("密码不能为空！！");
                txtPwd.Focus();
            }
            if (txtPwd2.Text.Equals(string.Empty)) {
                MessageBox.Show("确认密码不能为空！！");
                txtPwd2.Focus();
            }
            if (txtVerify.Text.Equals(string.Empty)) {
                MessageBox.Show("验证码不能为空！！");
                txtVerify.Focus();
            }
            if (!txtPwd.Text.Equals(txtPwd2.Text)) {
                MessageBox.Show("两次密码不相等！！");
                txtPwd.Focus();
            }
            if (!txtVerify.Text.Equals(string.Empty) && !txtVerify.Text.Equals(validCode.CheckCode)) {
                MessageBox.Show("验证码输入错误！！");
                txtVerify.Focus();
            }
            if(txtPwd.Text.Equals(txtPwd2.Text) && txtVerify.Text.Equals(validCode.CheckCode)) {
                //MessageBox.Show(filename);
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                Byte[] mybyte = new byte[fs.Length];
                fs.Read(mybyte, 0, mybyte.Length);
                fs.Close();
                CUser user = new CUser(txtEmail.Text, CUser.doSome.initialization);
                if (!user.CUserName.Equals(string.Empty)) {
                    MessageBox.Show("该账号已存在，请输入一个新账号！");
                    txtEmail.Focus();
                }
                else {
                    user = new CUser("null", CUser.doSome.Insert);
                    if (user.Insert(txtEmail.Text, txtName.Text, txtPwd.Text, mybyte)) {
                        MessageBox.Show("注册成功！！");
                        this.Pass = true;
                        this.Hide();
                    }
                        
                }
            }
        }

        private void label5_Click (object sender, EventArgs e) {
            picVerify.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
        }

        private void txtEmail_KeyPress (object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r') {
                CUser user = new CUser(txtEmail.Text, CUser.doSome.initialization);
                if (!user.CUserName.Equals(string.Empty)) {
                    MessageBox.Show("该账号已存在，请输入一个新账号！");
                    txtEmail.Focus();
                }
            }
        }

        private void btnCancel_Click (object sender, EventArgs e) {
            this.Close();
            this.Pass = true;
        }
    }
}
