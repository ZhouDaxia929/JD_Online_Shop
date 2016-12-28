using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JD_Online_Shop_Dal;

namespace JD_Online_Shop_Bll {
    public class JDGood {
        private string goodId;
        private string goodName;
        private string goodNum;
        private string goodPrice;
        private string goodUrl;
        private string goodPicUrl;
        private string goodPic;
        private string goodDetils;
        private Good good;

        public string GoodId {
            set {
                goodId = value;
            }
            get {
                return goodId;
            }
        }
        public string GoodName {
            set {
                goodName = value;
            }
            get {
                return goodName;
            }
        }
        public string GoodNum {
            set {
                goodNum = value;
            }
            get {
                return goodNum;
            }
        }
        public string GoodPrice {
            set {
                goodPrice = value;
            }
            get {
                return goodPrice;
            }
        }
        public string GoodUrl {
            set {
                goodUrl = value;
            }
            get {
                return goodUrl;
            }
        }
        public string GoodPicUrl {
            set {
                goodPicUrl = value;
            }
            get {
                return goodPicUrl;
            }
        }
        public string GoodPic {
            set {
                goodPic = value;
            }
            get {
                return goodPic;
            }
        }
        public string GoodDetils {
            set {
                goodDetils = value;
            }
            get {
                return goodDetils;
            }
        }
        public JDGood (string goodId) {
            good = new Good(goodId);
            if (good.GoodId != "") {
                this.goodId = good.GoodId;
                this.goodName = good.GoodName;
                this.goodNum = good.GoodNum;
                this.goodPrice = good.GoodPrice;
                this.goodUrl = good.GoodUrl;
                this.goodPicUrl = good.GoodPicUrl;
                this.goodPic = good.GoodPic;
                this.goodDetils = good.GoodDetils;
            }
        }
        public static HashSet<string> getGoodIds () {
            return Good.getGoodIds();
        }
        public static HashSet<string> getGoodHotComment(string goodId) {
            return Good.getGoodHotComment(goodId);
        }
        public static HashSet<string> getGoodComment(string goodId) {
            return Good.getGoodComment(goodId);
        }
        public static string getGoodCommentSummary(string goodId) {
            return Good.getGoodCommentSummary(goodId);
        }
        public static string getGoodNum(string goodId) {
            return Good.getGoodNum(goodId);
        }
        public Byte[] getGoodPic(string goodId) {
            return Good.getGoodPic(goodId);
        }
    }
}
