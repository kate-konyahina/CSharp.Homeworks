using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._15.Task2
{
    internal class PurchaseMotorcycle
    {
        [CreditCardAttribute()]
        public string? CreditCardNumber { get; set; }

        public PurchaseMotorcycle(string? creditCardNumber)
        {
            if (new CreditCardAttribute().IsValid(creditCardNumber))
            {
                CreditCardNumber = creditCardNumber;
                Console.WriteLine("The card has passed.");
            }
            else throw new Exception("Wrong credit card format");
        }

    }
}
