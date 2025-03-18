using System;

namespace OCP
{
    class Qiwi : PaymentSystem
    {
        public Qiwi(PaymentSystemTypes system) : base(system)
        {
            Console.WriteLine($"Перевод на страницу {system}...");
        }
    }
}
