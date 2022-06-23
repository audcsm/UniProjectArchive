using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Inputs
    {
        public string nameOfTransaction;
        public string luxuryOrEssential;
        public double amountSpent;

        public Inputs(string transactionName, string transactionType, double transactionAmount)
        {
            nameOfTransaction = transactionName;
            luxuryOrEssential = transactionType;
            amountSpent = transactionAmount;
        }

        private void LuxOrEss()
        {
            if (luxuryOrEssential == "Luxury")
            {

            }
            else
            {

            }
        }
    }
}
