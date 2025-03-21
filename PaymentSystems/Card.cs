using System;

namespace OCP
{
    class Card : IPaymentSystem
    {
        public Card()
        {
            Console.WriteLine($"Вызов API банка эмитера карты {System}...");
        }

        public PaymentSystemTypes System { get => PaymentSystemTypes.Card; }
    }
}
