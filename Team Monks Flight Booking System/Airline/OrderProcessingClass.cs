using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Monks_Flight_Booking_System.TravelAgency;

namespace Team_Monks_Flight_Booking_System.Airline
{
    // Delegate for order confirmation
    public delegate void orderConfirmationDelegate(OrderClass orderConfirmed, double anountChanrged);

    class OrderProcessingClass
    {
        private static double tax = 10.2;
        private static int creditCardStart = 5000;
        private static int creditCardEnd = 7000;
        private static double locationCharge = 1.5;

        private static OrderClass confirmedOrderObject;

        // declaring order confirmation event
        public static event orderConfirmationDelegate orderConfirmationEvent;

        public OrderProcessingClass(OrderClass confirmedOrder)
        {
            OrderProcessingClass.confirmedOrderObject = confirmedOrder;
        }

        // Order processing class thread method
        public void runOrderProcessing()
        {
             // checking if the card format is correct and confirmed order object is not null
            if (confirmedOrderObject != null && isValidCreditCardFormat())
            {
                double totalAmount = calculateTotalAmount();
                 
                // once the order is confirmed reducing the number of available tickets
                Int32 availableTkt = AirlineClass.availableTickets;
                availableTkt -= confirmedOrderObject.NumTickets;
                AirlineClass.availableTickets = availableTkt;
                
                // this will emit order confirmation event for the handler in ConfirmationBufferClass
                if (orderConfirmationEvent != null)
                {
                    orderConfirmationEvent(confirmedOrderObject, totalAmount);
                }
            }

        }

        private static Boolean isValidCreditCardFormat()
        {
            if (confirmedOrderObject.CardNo > creditCardStart && confirmedOrderObject.CardNo < creditCardEnd)
                return true;
            else
                return false;
        }

        private static double calculateTotalAmount()
        {
            double ticketPrice = (confirmedOrderObject.UnitPrice) * (confirmedOrderObject.NumTickets);
            ticketPrice += ticketPrice * (tax + locationCharge) / 100;
            return ticketPrice;
        }
    }
}
