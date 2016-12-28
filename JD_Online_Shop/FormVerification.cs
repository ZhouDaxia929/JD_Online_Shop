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
    
    public partial class FormVerification : Form {
        public bool Pass { get; set; }
        private ValidCode validCode;
        private CUser user;
        public FormVerification (string userEmail) {
            InitializeComponent();
            Pass = false;
            user = new CUser(userEmail, CUser.doSome.initialization);
        }

        private void FormVerification_Load (object sender, EventArgs e) {
            validCode = new ValidCode(5, ValidCode.CodeType.Characters);
            picVerify.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            picVerify.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label5_Click (object sender, EventArgs e) {
            picVerify.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());
            picVerify.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnOK_Click (object sender, EventArgs e) {
            string name = "";
            if (!txtVer.Text.Equals(string.Empty) && !txtVer.Text.Equals(validCode.CheckCode)) {
                MessageBox.Show("验证码输入错误！！");
                txtVer.Focus();
            }
            else {
                if (user.Login(txtPwd.Text, ref name)) {
                    MessageBox.Show("验证成功！！");
                    this.Pass = true;
                    this.Hide();
                }
            }
        }
    }
}
