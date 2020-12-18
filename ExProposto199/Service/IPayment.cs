using System;
using System.Collections.Generic;
using System.Text;

namespace ExProposto199.Entities
{
    interface IPayment
    {
        public double CalcInstallment(int parc, double value);
    }
}
