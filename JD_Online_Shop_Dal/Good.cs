using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Online_Shop_Dal {
    public class Good {
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
        public static HashSet<string> getGoodIds () {
            HashSet<string> GoodIds = new HashSet<string>();
            string sql = "select * from Good";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataSet dataSet = helper.FillSet(sql, "goodIds");
            for(int i = 0; i < dataSet.Tables["goodIds"].Rows.Count; i++) {
                GoodIds.Add(dataSet.Tables["goodIds"].Rows[i]["goodId"].ToString());
            }
            return GoodIds;
        }
        public static HashSet<string> getGoodHotComment(string goodId) {
            HashSet<string> HotComment = new HashSet<string>();
            string sql = "select * from hotComment where goodId = '" + goodId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataSet dataSet = helper.FillSet(sql, "hotComment");
            for (int i = 0; i < dataSet.Tables["hotComment"].Rows.Count; i++) {
                HotComment.Add(dataSet.Tables["hotComment"].Rows[i]["name"].ToString() + "(" + dataSet.Tables["hotComment"].Rows[i]["count"].ToString() + ")");
            }
            return HotComment;
        }
        public static HashSet<string> getGoodComment(string goodId) {
            HashSet<string> GoodComment = new HashSet<string>();
            string sql = "select * from Comment where goodId = '" + goodId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataSet dataSet = helper.FillSet(sql, "goodComment");
            for (int i = 0; i < dataSet.Tables["goodComment"].Rows.Count; i++) {
                GoodComment.Add(dataSet.Tables["goodComment"].Rows[i]["referenceTime"].ToString() + "：" + dataSet.Tables["goodComment"].Rows[i]["content"].ToString());
            }
            return GoodComment;
        }
        public static string getGoodCommentSummary(string goodId) {
            string sql = "select * from CommentSummary where goodId = '" + goodId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataSet dataSet = helper.FillSet(sql, "CommentSummary");
            return dataSet.Tables["CommentSummary"].Rows[0]["commentCount"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["goodRateShow"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["generalRateShow"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["poorRateShow"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["goodCount"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["generalCount"].ToString() + "|"
                + dataSet.Tables["CommentSummary"].Rows[0]["poorCount"].ToString();
        }
        public static string getGoodNum(string goodId) {
            string sql = "select * from Good where goodId = '" + goodId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataSet dataSet = helper.FillSet(sql, "GoodNum");
            return dataSet.Tables["GoodNum"].Rows[0]["goodNum"].ToString();
        }
        public static Byte[] getGoodPic(string goodId) {
            Byte[] mybyte = new byte[0];
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "Select goodId, goodPic from Good where goodId = '" + goodId + "'";
            DataSet dataSet = helper.FillSet(sSql, "GoodPicTest");
            int c = dataSet.Tables["GoodPicTest"].Rows.Count;
            if (c > 0) {
                mybyte = (Byte[])(dataSet.Tables["GoodPicTest"].Rows[c - 1]["goodPic"]);
            }
            return mybyte;
        }
    }
}
