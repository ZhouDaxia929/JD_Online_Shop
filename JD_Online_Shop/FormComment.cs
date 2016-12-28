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
    public partial class FormComment : Form {
        public FormComment (string goodId) {
            InitializeComponent();
            HashSet<string> Comment = JDGood.getGoodComment(goodId);
            string[] str = new string[10];
            int m = 0;
            foreach(string s in Comment) {
                if (m < 10) {
                    str[m++] = s;
                }
                else
                    break;
            }
            lbl1_1.Text = "1. " + str[0];
            lbl1_2.Text = "2. " + str[1];
            lbl1_3.Text = "3. " + str[2];
            lbl1_4.Text = "4. " + str[3];
            lbl1_5.Text = "5. " + str[4];
            lbl1_6.Text = "6. " + str[5];
            lbl1_7.Text = "7. " + str[6];
            lbl1_8.Text = "8. " + str[7];
            lbl1_9.Text = "9. " + str[8];
            lbl1_10.Text = "10. " + str[9];
        }
    }
}
