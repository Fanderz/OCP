using System;

namespace OCP
{
    class Qiwi : IPaymentSystem
    {
        public Qiwi()
        {
            Console.WriteLine($"Перевод на страницу {System}...");
        }

        public PaymentSystemTypes System => PaymentSystemTypes.QIWI;
    }
}
