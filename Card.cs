using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        //dette er en abstrakt property som er en string
        protected abstract string CardType { get; set; }

        //dette er en abstrakt property som er en string
        protected abstract string CardHolderName { get; set; }

        //dette er en abstrakt property som er en string
        protected abstract string CardNumber { get; set; }

        //dette er en abstrakt property som er en int
        protected abstract int CardNumberLength { get; set; }

        //dette er en abstrakt property som er en DateTime (Dato)
        protected abstract DateTime ExpiryDate { get; set; }

        //dette er en abstrakt property som er en string
        protected abstract string AccountNumber { get; set; }

        //dette er en liste som ikke er instantiere endnu
        protected List<string> prefix;

        //Denne metode autogenerere et kortnummer ud fra typen
        protected string CardNumberGenerator(List<string> prefix, int cardNumberLength)
        {
            Random random = new Random();

            string cardNumber = prefix[random.Next(prefix.Count)];

            for (; cardNumber.Length < cardNumberLength;)
            {
                cardNumber += random.Next(0, 10);
            }

            return cardNumber;
        }
        //Denne metode autogenerere et kontonummer
        protected string AccountNumberGenerator()
        {
            Random random = new Random();

            string cardNumber = "3520";

            for (; cardNumber.Length < 14;)
            {
                cardNumber += random.Next(0, 10);
            }

            return cardNumber;
        }
    }
}
