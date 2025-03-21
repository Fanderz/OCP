using System;

namespace OCP
{
    class WebMoney : IPaymentSystem
    {
        public WebMoney()
        {
            Console.WriteLine($"Вызов API {System}...");
        }

        public PaymentSystemTypes System => PaymentSystemTypes.WebMoney;
    }
}
