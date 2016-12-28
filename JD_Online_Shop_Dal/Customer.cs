using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Online_Shop_Dal
{
    public class Customer
    {
        private string Email; //账号
        private string Name;  //姓名
        private string Phone; //手机号码
        private string Pic; //头像
        private string Sex;  //性别
        private string Age;  //年龄             
        private string Pwd; //密码
        private string Address;  //地址
        private string ShoppingCart; //购物车
        private string Balance; //余额
        private string Cost;  //支出
        private string Logistics; //送货方式
        private HashSet<string> Order; //全部订单编号

        private OperationType OT;
        public enum OperationType { initialization, Insert, Update, getPic };

        public string CustomerName {
            set {
                Name = value;
            }
            get {
                return Name;
            }
        }
        public string CustomerEmail {
            set {
                Email = value;
            }
            get {
                return Email;
            }
        }
        public string CustomerPwd {
            set {
                Pwd = value;
            }
            get {
                return Pwd;
            }
        }
        public string CustomerPhone {
            set {
                Phone = value;
            }
            get {
                return Phone;
            }
        }
        public string CustomerSex {
            set {
               Sex = value;
            }
            get {
                return Sex;
            }
        }
        public string CustomerAddress {
            set {
                Address = value;
            }
            get {
                return Address;
            }
        }
        public string CustomerBalance {
            set {
                Balance = value;
            }
            get {
                return Balance;
            }
        }
        public long rows { get; set; }
        public Customer(string Email, string Name, string Phone) {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }
        public string Text {
            get {
                return this.Email + ", " + this.Name + ", " + this.Phone;
            }
        }
        ///<summary>
        ///功能，通过账号从数据库中获取此用户的信息，构造一个用户实例
        /// </summary>
        /// <param name="id"></param>
        public Customer(string Email, OperationType _OT) {
            this.OT = _OT;
            if(OT == OperationType.initialization) {
                string sql = "select * from Customer where Email = '" + Email + "'";
                DBHelper helper = new DBHelper("JD_Online_Shop");
                DataTable table = helper.FillTable(sql);
                if (table != null && table.Rows.Count > 0) {
                    this.Email = table.Rows[0]["Email"].ToString();
                    this.Name = table.Rows[0]["Name"].ToString();
                    this.Pwd = table.Rows[0]["Pwd"].ToString();
                    this.Phone = table.Rows[0]["Phone"].ToString();
                    this.Pic = table.Rows[0]["Pic"].ToString();
                    this.Sex = table.Rows[0]["Sex"].ToString();
                    this.Age = table.Rows[0]["Age"].ToString();
                    this.Address = table.Rows[0]["Address"].ToString();
                    this.ShoppingCart = table.Rows[0]["ShoppingCart"].ToString();
                    this.Balance = table.Rows[0]["Balance"].ToString();
                    this.Cost = table.Rows[0]["Cost"].ToString();
                    this.Logistics = table.Rows[0]["Logistics"].ToString();
                }
                else
                    this.Email = "";
            }
        }

        public bool UserRegister(string email, string name, string pwd, string phone, Byte[] pic) {
            DBHelper helper = new DBHelper("JD_Online_Shop");
            rows = helper.Insert(email, name, pwd, phone, pic);
            if(rows == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool UserUpdate(string email, string name, string phone, string sex, string address, string pwd, Byte[] pic) {
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "update Customer set Name = " + "'" + name + "'" + ", Phone = " + "'" + phone + "'" +
                ", Sex = " + "'" + sex + "'" + ", Address = " + "'" + address + "'" + ", Pwd = " + "'" + pwd + "'"
                + ", Pic = " + "@img" + " where Email = '" + email + "'";
            rows = helper.AllUpdate(sSql, pic);
            if (rows == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool UserUpdateWithoutPwd (string email, string name, string phone, string sex, string address, Byte[] pic) {
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "update Customer set Name = " + "'" + name + "'" + ", Phone = " + "'" + phone + "'" +
                ", Sex = " + "'" + sex + "'" + ", Address = " + "'" + address + "'"
                + ", Pic = " + "@img" + " where Email = '" + email + "'";
            rows = helper.AllUpdate(sSql, pic);
            if (rows == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool UserUpdateWithBalance(string email, string Balance, string cardId) {
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "update Customer set Balance = '" + Balance + "' where email = '" + email + "'";
            string sSql2 = "update recharge set isUsed = 1 where CardId = '" + cardId + "'";
            string sSql3 = "insert into CardUse(CardId, Email) values (" + "'" + cardId + "', '" + email + "')";
            rows = helper.Update(sSql);
            long rows2 = helper.Update(sSql2);
            long rows3 = helper.Update(sSql3);
            if(rows == 1 && rows2 == 1 && rows3 == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool UpdateBalance(string email, string Balance, string goodId, string Price, int Num) {
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "update Customer set Balance = '" + Balance + "' where email = '" + email + "'";
            string sSql2 = "insert into sale(goodId, Email, Price, Num) values (" + "'" + goodId + "', '"
                + email + "', '" + Price + "'," + Num + ")";
            string sSql3 = "update Good set goodNum = goodNum - " + Num + " where goodId = '" + goodId + "'";
            long back = helper.Update(sSql);
            long back2 = helper.Update(sSql2);
            long back3 = helper.Update(sSql3);
            if (back == 1 && back2 == 1 && back3 == 1) {
                return true;
            }
            else {
                return false;
            }
        }
        public Byte[] getPic(string Email) {
            Byte[] mybyte = new byte[0];
            DBHelper helper = new DBHelper("JD_Online_Shop");
            string sSql = "Select Email, Pic from Customer where Email = '" + Email + "'";
            DataSet dataSet = helper.FillSet(sSql, "PicTest");
            int c = dataSet.Tables["PicTest"].Rows.Count;
            if (c > 0) {
                mybyte = (Byte[])(dataSet.Tables["PicTest"].Rows[c - 1]["Pic"]);
            }
            return mybyte;
        }
    }
}
