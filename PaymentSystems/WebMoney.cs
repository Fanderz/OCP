using System;

namespace OCP
{
    class WebMoney : PaymentSystem
    {
        public WebMoney(PaymentSystemTypes system) : base(system)
        {
            Console.WriteLine($"Вызов API {system}...");
        }
    }
}
