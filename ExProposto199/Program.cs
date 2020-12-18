using ExProposto199.Entities;
using ExProposto199.Service;
using System;
using System.Globalization;

namespace ExProposto199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy): ");
            DateTime Date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double ContractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int mounths = int.Parse(Console.ReadLine());

            Contract Contract = new Contract(Number, Date, ContractValue);

            Payment Payment = new Payment(new PayPal());
            Payment.Process(mounths, Contract);

            Console.WriteLine("");
            Console.WriteLine("Installments:");
            foreach (Installment item in Contract.installments)
            {
                Console.WriteLine(item);
            }
        }
    }
}
