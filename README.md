# Flight Booking System ![](https://img.shields.io/badge/C%23--brightgreen.svg) 
## Developed by - Girish Patni and Siddharth Jain

This is a C# console based application simulating an Airline Ticket Booking System.

### This system consists of three main components:-
1. Airline - Provides tickets and generate ticket price cut event
2. Travel Agency - Travel agency actively listens for price cut event and book a number of tickets based on amount of price cut
3. Buffer - It manages the communication between travel agencies and airlines by allowing only 3 threads at a time.
