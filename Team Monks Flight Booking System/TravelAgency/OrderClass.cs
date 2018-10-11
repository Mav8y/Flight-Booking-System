using System;

namespace Team_Monks_Flight_Booking_System.TravelAgency
{
    // It represents the order object sent from travel agencies to airlines
    public class OrderClass
    {
        private string senderId;

        public string SenderId
        {
            get { return senderId; }
            set { senderId = value; }
        }

        private int cardNo;

        public int CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        private string receiverID;
        public string ReceiverID
        {
            get { return receiverID; }
            set { receiverID = value; }
        }

        private int numTickets;

        public int NumTickets
        {
            get { return numTickets; }
            set { numTickets = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
    }
}
