using System;

namespace OCP
{
    class Card : PaymentSystem
    {
        public Card(PaymentSystemTypes system) : base(system)
        {
            Console.WriteLine($"Вызов API банка эмитера карты {system}...");
        }
    }
}
