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
        private HashSet<string> GoodIds;
        private int i = 0;
        private JDGood[] goods = new JDGood[12];
        private MemoryStream[] ms = new MemoryStream[12];
        public FormMain () {
            InitializeComponent();
        }

        private void FormMain_Load (object sender, EventArgs e) {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            if (frmLogin.Pass) {
                UserEmail = frmLogin.UserEmail;
                UserName = frmLogin.UserName;
                frmLogin.Hide();
                this.Show();
                this.lblUserName.Text = UserName;
                user = new CUser(UserEmail, CUser.doSome.initialization);
                MemoryStream ms = new MemoryStream(user.getUserPic(user.CUserEmail));
                picUser.Image = Image.FromStream(ms);
                picUser.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                MessageBox.Show("登录异常，系统即将关闭！！");
                Application.Exit();
            }
            GoodIds = JDGood.getGoodIds();
            
            foreach(string goodId in GoodIds) {
                goods[i] = new JDGood(goodId);
                ms[i] = new MemoryStream(goods[i].getGoodPic(goods[i].GoodId));
                if(i++ == 11) {
                    break;
                }
            }
            setBtn();
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

        private void pictureBox14_Click (object sender, EventArgs e) {
            int count = 0, j = 0;
            int next = i + 11;
            int init = i;
            foreach (string goodId in GoodIds) {
                if(count < init) {
                    count++;
                    continue;
                }
                goods[j] = new JDGood(goodId);
                ms[j] = new MemoryStream(goods[j].getGoodPic(goods[j].GoodId));
                j++;
                if (i++ == next) {
                    break;
                }
            }
            setBtn();
        }
        private void pictureBox17_Click (object sender, EventArgs e) {
            if(i > 11) {
                i -= 24;
                int count = 0, j = 0;
                int next = i + 11;
                int init = i;
                foreach (string goodId in GoodIds) {
                    if (count < init) {
                        count++;
                        continue;
                    }
                    goods[j] = new JDGood(goodId);
                    ms[j] = new MemoryStream(goods[j].getGoodPic(goods[j].GoodId));
                    j++;
                    if (i++ == next) {
                        break;
                    }
                }
                setBtn();
            }
        }
        private void setBtn () {
            lbl1_1.Text = goods[0].GoodName.Substring(0, 16);
            lbl1_2.Text = "￥" + goods[0].GoodPrice;
            pic1.Image = Image.FromStream(ms[0]);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            lbl2_1.Text = goods[1].GoodName.Substring(0, 16);
            lbl2_2.Text = "￥" + goods[1].GoodPrice;
            pic2.Image = Image.FromStream(ms[1]);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            lbl3_1.Text = goods[2].GoodName.Substring(0, 16);
            lbl3_2.Text = "￥" + goods[2].GoodPrice;
            pic3.Image = Image.FromStream(ms[2]);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            lbl4_1.Text = goods[3].GoodName.Substring(0, 16);
            lbl4_2.Text = "￥" + goods[3].GoodPrice;
            pic4.Image = Image.FromStream(ms[3]);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            lbl5_1.Text = goods[4].GoodName.Substring(0, 16);
            lbl5_2.Text = "￥" + goods[4].GoodPrice;
            pic5.Image = Image.FromStream(ms[4]);
            pic5.SizeMode = PictureBoxSizeMode.Zoom;

            lbl6_1.Text = goods[5].GoodName.Substring(0, 16);
            lbl6_2.Text = "￥" + goods[5].GoodPrice;
            pic6.Image = Image.FromStream(ms[5]);
            pic6.SizeMode = PictureBoxSizeMode.Zoom;
            lbl7_1.Text = goods[6].GoodName.Substring(0, 16);
            lbl7_2.Text = "￥" + goods[6].GoodPrice;
            pic7.Image = Image.FromStream(ms[6]);
            pic7.SizeMode = PictureBoxSizeMode.Zoom;
            lbl8_1.Text = goods[7].GoodName.Substring(0, 16);
            lbl8_2.Text = "￥" + goods[7].GoodPrice;
            pic8.Image = Image.FromStream(ms[7]);
            pic8.SizeMode = PictureBoxSizeMode.Zoom;
            lbl9_1.Text = goods[8].GoodName.Substring(0, 16);
            lbl9_2.Text = "￥" + goods[8].GoodPrice;
            pic9.Image = Image.FromStream(ms[8]);
            pic9.SizeMode = PictureBoxSizeMode.Zoom;
            lbl10_1.Text = goods[9].GoodName.Substring(0, 16);
            lbl10_2.Text = "￥" + goods[9].GoodPrice;
            pic10.Image = Image.FromStream(ms[9]);
            pic10.SizeMode = PictureBoxSizeMode.Zoom;
            lbl11_1.Text = goods[10].GoodName.Substring(0, 16);
            lbl11_2.Text = "￥" + goods[10].GoodPrice;
            pic11.Image = Image.FromStream(ms[10]);
            pic11.SizeMode = PictureBoxSizeMode.Zoom;
            lbl12_1.Text = goods[11].GoodName.Substring(0, 16);
            lbl12_2.Text = "￥" + goods[11].GoodPrice;
            pic12.Image = Image.FromStream(ms[11]);
            pic12.SizeMode = PictureBoxSizeMode.Zoom;
        } 
        private void initGoodDetail(string goodId, string userEmail) {
            FormGoodDetail frmGoodDetail = new FormGoodDetail(goodId, UserEmail);
            frmGoodDetail.ShowDialog();
        }

        private void pictureBox15_Click (object sender, EventArgs e) {
            initGoodDetail(goods[0].GoodId, UserEmail);
        }

        private void pictureBox16_Click (object sender, EventArgs e) {
            initGoodDetail(goods[1].GoodId, UserEmail);
        }

        private void pictureBox18_Click (object sender, EventArgs e) {
            initGoodDetail(goods[2].GoodId, UserEmail);
        }

        private void pictureBox20_Click (object sender, EventArgs e) {
            initGoodDetail(goods[3].GoodId, UserEmail);
        }

        private void pictureBox22_Click (object sender, EventArgs e) {
            initGoodDetail(goods[4].GoodId, UserEmail);
        }

        private void pictureBox24_Click (object sender, EventArgs e) {
            initGoodDetail(goods[5].GoodId, UserEmail);
        }

        private void pictureBox26_Click (object sender, EventArgs e) {
            initGoodDetail(goods[6].GoodId, UserEmail);
        }

        private void pictureBox28_Click (object sender, EventArgs e) {
            initGoodDetail(goods[7].GoodId, UserEmail);
        }

        private void pictureBox30_Click (object sender, EventArgs e) {
            initGoodDetail(goods[8].GoodId, UserEmail);
        }

        private void pictureBox32_Click (object sender, EventArgs e) {
            initGoodDetail(goods[9].GoodId, UserEmail);
        }

        private void pictureBox34_Click (object sender, EventArgs e) {
            initGoodDetail(goods[10].GoodId, UserEmail);
        }

        private void pictureBox36_Click (object sender, EventArgs e) {
            initGoodDetail(goods[11].GoodId, UserEmail);
        }

        private void pic1_Click (object sender, EventArgs e) {
            initGoodDetail(goods[0].GoodId, UserEmail);
        }

        private void pic2_Click (object sender, EventArgs e) {
            initGoodDetail(goods[1].GoodId, UserEmail);
        }

        private void pic3_Click (object sender, EventArgs e) {
            initGoodDetail(goods[2].GoodId, UserEmail);
        }

        private void pic4_Click (object sender, EventArgs e) {
            initGoodDetail(goods[3].GoodId, UserEmail);
        }

        private void pic5_Click (object sender, EventArgs e) {
            initGoodDetail(goods[4].GoodId, UserEmail);
        }

        private void pic6_Click (object sender, EventArgs e) {
            initGoodDetail(goods[5].GoodId, UserEmail);
        }

        private void pic7_Click (object sender, EventArgs e) {
            initGoodDetail(goods[6].GoodId, UserEmail);
        }

        private void pic8_Click (object sender, EventArgs e) {
            initGoodDetail(goods[7].GoodId, UserEmail);
        }

        private void pic9_Click (object sender, EventArgs e) {
            initGoodDetail(goods[8].GoodId, UserEmail);
        }

        private void pic10_Click (object sender, EventArgs e) {
            initGoodDetail(goods[9].GoodId, UserEmail);
        }

        private void pic11_Click (object sender, EventArgs e) {
            initGoodDetail(goods[10].GoodId, UserEmail);
        }

        private void pic12_Click (object sender, EventArgs e) {
            initGoodDetail(goods[11].GoodId, UserEmail);
        }
    }
}
