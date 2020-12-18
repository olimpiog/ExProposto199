using System;
using System.Collections.Generic;
using System.Text;

namespace ExProposto199.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> installments { get; private set; }

        public Contract()
        {
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installments = new List<Installment>();
        }

        public void AddInstallments(Installment item)
        {
            installments.Add(item);
        }
    }
}
