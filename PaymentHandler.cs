using OCP.PaymentSystemFabrics;
using System;

namespace OCP
{
    class PaymentHandler
    {
        private IPaymentSystem _system;

        public PaymentHandler(IPaymentSystem system)
        {
            _system = system;
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Вы оплатили с помощью {_system.System}");
            Console.WriteLine($"Проверка платежа через {_system.System}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
