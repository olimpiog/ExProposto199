using ExProposto199.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExProposto199.Service
{
    class Payment
    {
        private IPayment _payment;

        public Payment(IPayment payment)
        {
            _payment = payment;
        }

        public void Process(int months, Contract contract)
        {
            double parc = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double value = _payment.CalcInstallment(i, parc);
                contract.AddInstallments(new Installment(date, value));
            }          
        }

    }
}
