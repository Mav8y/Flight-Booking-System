This is a C# console based application simulating an Airline Ticket Booking System.

### This system consists of three main components:-
1. Airline - Provides tickets and generate ticket price cut event.
2. Travel Agency - Travel agency actively listens for price cut event from airlines and places an order of tickets.
3. Buffer - It manages the communication between travel agencies and airlines by allowing only 3 threads at a time.
