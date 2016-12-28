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
    public partial class FormPay : Form {
        private JDGood good;
        private CUser user;
        private int num;
        private double price;
        private double balance;
        public bool Pass { get; set; }
        public FormPay (string goodId, string userEmail, int num) {
            InitializeComponent();
            good = new JDGood(goodId);
            user = new CUser(userEmail, CUser.doSome.initialization);
            this.num = num;
            price = Convert.ToDouble(good.GoodPrice);
            balance = Convert.ToDouble(user.CUserBalance);
        }

        private void FormPay_Load (object sender, EventArgs e) {
            lblgoodId.Text = good.GoodId;
            lblgoodPrice.Text = good.GoodPrice;
            lblBa.Text = user.CUserBalance;
            lblCount.Text = Convert.ToString(num);
            lblSumPrice.Text = Convert.ToString(Convert.ToDouble(price * num));
        }

        private void button2_Click (object sender, EventArgs e) {
            if(price * num < balance) {
                FormVerification frmVerification = new FormVerification(user.CUserEmail);
                frmVerification.ShowDialog();
                if (frmVerification.Pass) {
                    balance = balance - price * num;
                    if(user.setBalance(user.CUserEmail, Convert.ToString(balance), good.GoodId, good.GoodPrice, num)) {
                        lblBa.Text = Convert.ToString(balance);
                        MessageBox.Show("已生成订单！！");
                        this.button2.Enabled = false;
                    }
                }
            }
            else {
                MessageBox.Show("余额不足！！");
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
