using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Online_Shop_Dal {
    class Good {
        private string goodId;
        private string goodName;
        private string goodNum;
        private string goodPrice;
        private string goodUrl;
        private string goodPicUrl;
        private string goodPic;
        private string goodDetils;
        
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
        public Good (string goodId) {
            string sql = "select * from Good where goodId = '" + goodId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataTable table = helper.FillTable(sql);
            if (table != null && table.Rows.Count > 0) {
                this.goodId = table.Rows[0]["goodId"].ToString();
                this.goodName = table.Rows[0]["goodName"].ToString();
                this.goodNum = table.Rows[0]["goodNum"].ToString();
                this.goodPrice = table.Rows[0]["goodPrice"].ToString();
                this.goodUrl = table.Rows[0]["goodUrl"].ToString();
                this.goodPicUrl = table.Rows[0]["goodPicUrl"].ToString();
                this.goodPic = table.Rows[0]["goodPic"].ToString();
                this.goodDetils = table.Rows[0]["goodDetils"].ToString();
            }
            else {
                this.goodId = string.Empty;
            }
        }
    }
}
