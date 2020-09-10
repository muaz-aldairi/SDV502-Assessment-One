using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCinemas
{
    public class StateCinemas
    {
       public Decimal Adult_Before_5 (int quantity, string person, string day, decimal time) 
        {
            decimal totalPrice = 0;
           decimal ticketPrice = 14.50M;
            if( person=="Adult" && time<5 && day!="Tuesday") {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }


        public Decimal Adult_After_5(int quantity, string person, string day, decimal time)
        {
            decimal totalPrice = 0;
            decimal ticketPrice = 17.50M;
            if (person == "Adult" && time >= 5 && day != "Tuesday")
            {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }


        public Decimal Adult_Tuesday(int quantity, string person, string day)
        {
            decimal totalPrice = 0;
            decimal ticketPrice = 13M;
            if (person == "Adult" && day == "Tuesday")
            {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }

        public Decimal Child_Under_16(int quantity, string person)
        {
            decimal totalPrice = 0;
            decimal ticketPrice = 12M;
            if (person == "Child")
            {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }

        public Decimal Senior(int quantity, string person)
        {
            decimal totalPrice = 0;
            decimal ticketPrice = 12.5M;
            if (person == "Senior")
            {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }

        public Decimal Student(int quantity, string person)
        {
            decimal totalPrice = 0;
            decimal ticketPrice = 14M;
            if (person == "Student")
            {

                totalPrice = quantity * ticketPrice;
            }

            return totalPrice;
        }
    }
}
