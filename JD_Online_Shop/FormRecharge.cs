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
    public partial class FormRecharge : Form {
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        private CUser user;
        private MCard card;
        public FormRecharge () {
            InitializeComponent();
        }

        private void FormRecharge_Load (object sender, EventArgs e) {
            user = new CUser(this.UserEmail, CUser.doSome.initialization);
            lblName.Text = this.UserName;
            lblBalance.Text = this.user.CUserBalance;
        }

        private void lblRC_Click (object sender, EventArgs e) {
            lblCardID.Visible = true;
            lblCardPwd.Visible = true;
            lblDe.Visible = true;
            lblDen.Visible = true;
            lblOK.Visible = true;
            lblCancel.Visible = true;

            txtCardID.Visible = true;
            txtCardPwd.Visible = true;
        }

        private void lblOK_Click (object sender, EventArgs e) {
            if (txtCardID.Text.Equals(string.Empty)) {
                MessageBox.Show("卡号不能为空！！");
            }
            else {
                card = new MCard(txtCardID.Text);
                if (card.cardId.Equals(string.Empty)) {
                    MessageBox.Show("此卡号不存在！！请重新输入！");
                    txtCardID.Focus();
                }
                else {
                    if (card.IsUsed == true) {
                        MessageBox.Show("此卡号已被使用！！请重新输入！");
                        txtCardID.Focus();
                    }
                    else {
                        card = new MCard(txtCardID.Text);
                        if (card.cardId != "" && !txtCardPwd.Text.Equals(string.Empty) && card.isPwdRight(txtCardPwd.Text)) {
                            double money = Convert.ToDouble(lblBalance.Text) + Convert.ToDouble(card.cardDenomination);
                            if (user.UpdateBalance(user.CUserEmail, Convert.ToString(money), card.cardId)) {
                                MessageBox.Show("充值成功！！");
                                lblBalance.Text = Convert.ToString(money);
                                lblOK.Enabled = false;
                            }
                        }
                        else {
                            MessageBox.Show("卡号或密码错误！！！");
                        }
                    }
                }
            }   
        }

        private void txtCardID_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r' || e.KeyChar == '\t') {
                if (txtCardID.Text.Equals(string.Empty)) {
                    MessageBox.Show("卡号不能为空！！");
                }
                else {
                    card = new MCard(txtCardID.Text);
                    if (card.cardId.Equals(string.Empty)) {
                        MessageBox.Show("此卡号不存在！！请重新输入！");
                        txtCardID.Focus();
                    }
                    else {
                        if(card.IsUsed == true) {
                            MessageBox.Show("此卡号已被使用！！请重新输入！");
                            txtCardID.Focus();
                        }
                        else {
                            lblDen.Text = card.cardDenomination;
                        }
                    }
                }
            }
        }
    }
}
