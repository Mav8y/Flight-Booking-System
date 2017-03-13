using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private Int32 cardNo;
        public Int32 CardNo
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

        private Int32 numTickets;

        public Int32 NumTickets
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
