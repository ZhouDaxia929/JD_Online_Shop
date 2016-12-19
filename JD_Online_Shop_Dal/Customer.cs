using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Online_Shop_Dal
{
    public class Customer
    {
        private string Name;  //姓名
        private string Sex;  //性别
        private string Age;  //年龄
        private string Phone; //手机号码
        private string Account; //账号
        private string Pwd; //密码
        private string Address;  //地址
        private string ShoppingCart; //购物车
        private double Balance; //余额
        private double Cost;  //支出
        private string Logistics; //送货方式
        private HashSet<string> Order; //全部订单编号

        public string CustomerName {
            set {
                Name = value;
            }
            get {
                return Name;
            }
        }
        public Customer(string Name, string Phone, string Account) {
            this.Name = Name;
            this.Phone = Phone;
            this.Account = Account;
        }
    }
}
