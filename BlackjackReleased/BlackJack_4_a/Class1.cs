using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFirst
{
    public class Card
    {
        public int cardNum;
        public string cardID; //this could allow for multiple decks?  Like by using aceHearts and aceHearts2 and aceHearts3, etc.  All other variables would remain the same.
        public int rank = 10; // 11 for aces (and we need a way to bring it down to 1)
        public bool inDrawDeck = true; // True = able to be drawn by dealer


        public Card(int cardNum, string cardID, int rank, bool inDrawDeck) //For all cards but Aces
        {
            this.cardNum = cardNum;
            this.cardID = cardID;
            this.rank = rank;
            this.inDrawDeck = inDrawDeck;

        }


        public string GetCardID()
        {
            return cardID;
        }

        public void SetCardID(string cardID)
        {
            this.cardID = cardID;
        }
    }
}
