﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VISA : Card
    {
        //Dette er en string property der bliver overskriver 
        protected override string CardType { get; set; }

        //Dette er en string property der bliver overskriver 
        protected override string CardHolderName { get; set; }

        //Dette er en string property der bliver overskriver 
        protected override string CardNumber { get; set; }

        //Dette er en int property der bliver overskriver 
        protected override int CardNumberLength { get; set; }

        //Dette er en DateTime property der bliver overskriver 
        protected override DateTime ExpiryDate { get; set; }

        //Dette er en string property der bliver overskriver 
        protected override string AccountNumber { get; set; }

        //dette er en liste som bliver instantieret og får tildelt værdier
        protected new List<string> prefix = new List<string> { "4" };

        //Dette er en constructor som kun kan instantiere indefra denne klasse
        private VISA()
        {
            CardType = "VISA";
            ExpiryDate = DateTime.Now.AddYears(5);
            CardNumberLength = 16;
            CardNumber = CardNumberGenerator(prefix, CardNumberLength);
            AccountNumber = AccountNumberGenerator();
        }
        //Dette er en constructor som kan instantiere alle steder, hvis den får sit parameter som er en string
        public VISA(string cardHolderName) : this()
        {
            CardHolderName = cardHolderName;
        }

        //Denne metode overskriver ToString metoden i C#
        public override string ToString()
        {
            return $"This is a {CardType}\n\tName on the card: {CardHolderName}\n\tCard number: {CardNumber}\n\tExpiry date: {ExpiryDate:MM-yyyy}\n\tAccount number: {AccountNumber}";
        }
    }
}
