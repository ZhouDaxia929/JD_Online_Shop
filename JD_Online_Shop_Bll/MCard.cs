using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JD_Online_Shop_Dal;

namespace JD_Online_Shop_Bll {
    public class MCard {
        private string CardId;
        private string CardDenomination;
        private bool isUsed;
        private Card card;

        public string cardId {
            set {
                CardId = value;
            }
            get {
                return CardId;
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
        public MCard(string CardId) {
            card = new Card(CardId);
            if(card.cardId != "") {
                this.cardId = card.cardId;
                this.cardDenomination = card.cardDenomination;
                this.isUsed = card.IsUsed;
            }
            else {
                this.cardId = string.Empty;
                this.cardDenomination = string.Empty;
                this.isUsed = false;
            }
        }
        public bool isPwdRight(string pwd) {
            bool result = false;
            if(card.cardId != "" && MD5.MD5_Hash(pwd) == card.cardPwd) {
                result = true;
            }
            return result;
        }
    }
}
