using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Online_Shop_Dal {
    public class Card {
        private string CardId;
        private string CardPwd;
        private string CardDenomination;
        private bool isUsed;
        
        public string cardId {
            set {
                CardId = value;
            }
            get {
                return CardId;
            }
        } 
        public string cardPwd {
            set {
                CardPwd = value;
            }
            get {
                return CardPwd;
            }
        }
        public string cardDenomination {
            set {
                CardDenomination = value;
            }
            get {
                return CardDenomination;
            }
        }
        public bool IsUsed {
            set {
                isUsed = value;
            }
            get {
                return isUsed;
            }
        }

        public Card(string CardId) {
            string sql = "select * from recharge where CardId = '" + CardId + "'";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            DataTable table = helper.FillTable(sql);
            if(table != null && table.Rows.Count > 0) {
                this.CardId = table.Rows[0]["CardId"].ToString();
                this.CardPwd = table.Rows[0]["CardPwd"].ToString();
                this.CardDenomination = table.Rows[0]["CardDenomination"].ToString();
                string str = table.Rows[0]["isUsed"].ToString();
                if (str == "True")
                    this.IsUsed = true;
                else
                    this.IsUsed = false;
            }
            else {
                this.CardId = string.Empty;
            }
        }
    }
}
