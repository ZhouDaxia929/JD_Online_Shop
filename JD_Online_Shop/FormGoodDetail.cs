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
using System.Collections;

namespace JD_Online_Shop {
    public partial class FormGoodDetail : Form {
        
        private CUser user;
        private JDGood good;
        private HashSet<string> HotComment;
        public FormGoodDetail (string goodId, string userEmail) {
            InitializeComponent();
            user = new CUser(userEmail, CUser.doSome.initialization);
            good = new JDGood(goodId);
            if(good.GoodName.Length < 30) {
                int le = good.GoodName.Length / 2;
                lblGoodName.Text = good.GoodName.Substring(0, le);
                lblGoodName2.Text = good.GoodName.Substring(le);
            }
            else {
                int le = good.GoodName.Length / 3;
                lblGoodName.Text = good.GoodName.Substring(0, le);
                lblGoodName2.Text = good.GoodName.Substring(le, le * 2);
                lblGoodName3.Text = good.GoodName.Substring(le * 2);
            }
            lblGoodId.Text = "商品编号：" + good.GoodId;
            lblgoodPrice.Text = "￥" + good.GoodPrice;
            lblKC.Text = good.GoodNum;
            MemoryStream ms = new MemoryStream(good.getGoodPic(goodId));
            picGoodPic.Image = Image.FromStream(ms);
            picGoodPic.SizeMode = PictureBoxSizeMode.Zoom;

            HotComment = JDGood.getGoodHotComment(good.GoodId);
            string[] HC = new string[9];
            int i = 0;
            foreach(string hotComment in HotComment) {
                HC[i++] = hotComment;
                if (i == 9)
                    break;
            }
            lbl1_1.Text = HC[0];
            lbl1_2.Text = HC[1];
            lbl1_3.Text = HC[2];
            lbl1_4.Text = HC[3];
            lbl1_5.Text = HC[4];
            lbl1_6.Text = HC[5];
            lbl1_7.Text = HC[6];
            lbl1_8.Text = HC[7];
            lbl1_9.Text = HC[8];

            //商品详情处理
            string temp = good.GoodDetils.Replace("--", "|");
            string[] GD = temp.Split('|');
            string[] gd = new string[12];
            HashSet<string> hsGD = new HashSet<string>();
            foreach (string str in GD) {
                if (str != "") {
                    hsGD.Add(str);
                }
            }
            int m = 0;
            foreach(string str in hsGD) {
                if (m < 12) {
                    gd[m++] = str;
                }
                else
                    break;
            }
            if(gd[0].Length > 25) {
                lbl2_1.Text = gd[0].Substring(0, 25);
            }
            else {
                lbl2_1.Text = gd[0];
            }
            
            lbl2_2.Text = gd[1];
            lbl2_3.Text = gd[2];
            lbl2_4.Text = gd[3];
            lbl2_5.Text = gd[4];
            lbl2_6.Text = gd[5];
            lbl2_7.Text = gd[6];
            lbl2_8.Text = gd[7];
            lbl2_9.Text = gd[8];
            lbl2_10.Text = gd[9];
            lbl2_11.Text = gd[10];
            lbl2_12.Text = gd[11];

            string commentSummary = JDGood.getGoodCommentSummary(good.GoodId);
            string[] CS = commentSummary.Split('|');
            lblCommentCount.Text = "评价数：" + CS[0] + "+";
            lblgoodRateShow.Text = CS[1] + "%";

            numericUpDown1.Maximum = Convert.ToInt32(lblKC.Text);
        }

        private void pictureBox1_Click (object sender, EventArgs e) {
            FormComment frmComment = new FormComment(good.GoodId);
            frmComment.ShowDialog();
        }

        private void pictureBox2_Click (object sender, EventArgs e) {
            FormPay frmPay = new FormPay(good.GoodId, user.CUserEmail, (int)numericUpDown1.Value);
            frmPay.ShowDialog();
            lblKC.Text = JDGood.getGoodNum(good.GoodId);
        }
    }
}
