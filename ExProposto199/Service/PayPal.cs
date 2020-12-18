using ExProposto199.Entities;

namespace ExProposto199.Service
{
    class PayPal : IPayment
    {
        private const double JURO1 = 0.01;
        private const double JURO2 = 0.02;

        public double CalcInstallment(int parc, double value)
        {
            double _value = value;

            _value += value * JURO1 * parc;
            _value += _value * JURO2;

            return _value;           
        }
    }
}
