using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JD_Online_Shop_Dal;

namespace JD_Online_Shop_Bll
{
    public class CUser
    {
        private string cUserName;
        private string cUserEmail;
        private string cUserPhone;
        private string cUserSex;
        private string cUserAddress;
        private string cUserBalance;
        private Customer customer;
        private doSome dS;
        public enum doSome {initialization, Insert, Update};
        public string CUserName {
            set {
                cUserName = value;
            }
            get {
                return cUserName;
            }
        }
        public string CUserEmail {
            set {
                cUserEmail = value;
            }
            get {
                return cUserEmail;
            }
        }
        public string CUserPhone {
            set {
                cUserPhone = value;
            }
            get {
                return cUserPhone;
            }
        }
        public string CUserSex {
            set {
                cUserSex = value;
            }
            get {
                return cUserSex;
            }
        }
        public string CUserAddress {
            set {
                cUserAddress = value;
            }
            get {
                return cUserAddress;
            }
        }
        public string CUserBalance {
            set {
                cUserBalance = value;
            }
            get {
                return cUserBalance;
            }
        }
        public CUser(string Email, doSome _dS) {
            this.dS = _dS;
            if(_dS == doSome.initialization) {
                customer = new Customer(Email, Customer.OperationType.initialization);
                if (customer.CustomerEmail != "") {
                    this.CUserName = customer.CustomerName;
                    this.CUserEmail = customer.CustomerEmail;
                    this.CUserPhone = customer.CustomerPhone;
                    this.CUserSex = customer.CustomerSex;
                    this.CUserAddress = customer.CustomerAddress;
                    this.CUserBalance = customer.CustomerBalance;
                }
                else {
                    this.CUserName = "";
                    this.CUserEmail = "";
                }                 
            }
        } 
     
        public bool Login(string pwd, ref string cusername) {
            bool result = false;
            if(customer.CustomerEmail != "" && MD5.MD5_Hash(pwd) == customer.CustomerPwd) {
                cusername = customer.CustomerName;
                result = true;
            }
            return result;
        }
        public bool isPwdRight(string pwd) {
            bool result = false;
            if (customer.CustomerEmail != "" && MD5.MD5_Hash(pwd) == customer.CustomerPwd) {
                result = true;
            }
            return result;
        }
        public Byte[] getUserPic(string email) {
            Customer cm = new Customer("null", Customer.OperationType.getPic);
            return cm.getPic(email);
        }
        public bool Insert(string email, string name, string _pwd, Byte[] pic) {
            bool result = false;
            string pwd = MD5.MD5_Hash(_pwd);
            Customer cm = new Customer("null", Customer.OperationType.Insert);
            if(cm.UserRegister(email, name, pwd, "null", pic)) {
                result = true;
            }
            return result;
        }
        public bool Update(string email, string name, string phone, string sex, string address, string _pwd, Byte[] pic, bool isPwd) {
            bool result = false;
            string pwd = MD5.MD5_Hash(_pwd);
            Customer cm = new Customer("null", Customer.OperationType.Update);
            if(isPwd == true) {
                if (cm.UserUpdate(email, name, phone, sex, address, pwd, pic)) {
                    result = true;
                }
            }
            else {
                if (cm.UserUpdateWithoutPwd(email, name, phone, sex, address, pic))
                    result = true;
            }
            return result;
        }
        public bool UpdateBalance(string email, string Balance, string cardId) {
            bool result = false;
            Customer cm = new Customer("null", Customer.OperationType.Update);
            if(cm.UserUpdateWithBalance(email, Balance, cardId)) {
                result = true;
            }
            return result;
        }
    }
}
