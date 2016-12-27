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
    public partial class FormInfoSeting : Form {
        private bool flag = false;
        private string filename = string.Empty;
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        private CUser user;
        public FormInfoSeting () {
            InitializeComponent();
        }

        private void lblEdit_Click (object sender, EventArgs e) {
            this.txtEmail.ReadOnly = false;
            this.txtName.ReadOnly = false;
            this.txtPhone.ReadOnly = false;
            this.txtSex.ReadOnly = false;
            this.txtAddress.ReadOnly = false;
            this.txtPwd1.ReadOnly = false;
            this.txtPwd2.ReadOnly = false;
            this.txtPwd3.ReadOnly = false;

            this.txtPwd1.Visible = true;
            this.lblPwd1.Visible = true;

            this.lblEdit.Visible = false;
            this.lblSave.Visible = true;
            this.btnChoosePic.Visible = true;
        }

        private void btnChoosePic_Click (object sender, EventArgs e) {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK) {
                filename = this.openFileDialog1.FileName;
                picUser.Image = Image.FromFile(filename);
                this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                flag = true;
            }
        }

        private void lblSave_Click (object sender, EventArgs e) {
            if (txtPwd2.Text.Equals(txtPwd3.Text)) {
                if (flag == true) {
                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    Byte[] mybyte = new byte[fs.Length];
                    fs.Read(mybyte, 0, mybyte.Length);
                    fs.Close();
                    user = new CUser("null", CUser.doSome.Update);
                    if (user.Update(txtEmail.Text, txtName.Text, txtPhone.Text, txtSex.Text, txtAddress.Text, txtPwd2.Text, mybyte, lblPwd2.Visible)) {
                        MessageBox.Show("修改成功！！");
                    }
                }
                else {
                    user = new CUser(UserEmail, CUser.doSome.initialization);
                    Byte[] mybyte = user.getUserPic(user.CUserEmail);
                    user = new CUser("null", CUser.doSome.Update);
                    if (user.Update(txtEmail.Text, txtName.Text, txtPhone.Text, txtSex.Text, txtAddress.Text, txtPwd2.Text, mybyte, lblPwd2.Visible)) {
                        MessageBox.Show("修改成功！！");
                    }
                }

            }
            else {
                MessageBox.Show("两次密码不相等！！");
                txtPwd2.Focus();
            }
        }

        private void FormInfoSeting_Load (object sender, EventArgs e) {
            user = new CUser(UserEmail, CUser.doSome.initialization);
            txtEmail.Text = user.CUserEmail;
            txtName.Text = user.CUserName;
            txtPhone.Text = user.CUserPhone;
            txtSex.Text = user.CUserSex;
            txtAddress.Text = user.CUserAddress;
            MemoryStream ms = new MemoryStream(user.getUserPic(user.CUserEmail));
            picUser.Image = Image.FromStream(ms);
        }

        private void txtPwd1_KeyPress (object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r' || e.KeyChar == '\t') {
                if (user.isPwdRight(txtPwd1.Text)) {
                    this.lblPwd2.Visible = true;
                    this.lblPwd3.Visible = true;
                    this.txtPwd2.Visible = true;
                    this.txtPwd3.Visible = true;
                }
            }
        }
    }
}
