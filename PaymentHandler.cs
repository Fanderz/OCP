using OCP.PaymentSystemFabrics;
using System;

namespace OCP
{
    class PaymentHandler
    {
        private readonly IPaymentSystem _system;

        public PaymentHandler(PaymentSystemFactory factory)
        {
            _system = factory.Create();
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Вы оплатили с помощью {_system.System}");
            Console.WriteLine($"Проверка платежа через {_system.System}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
