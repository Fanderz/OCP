using System;

namespace OCP
{
    abstract class PaymentSystem
    {
        public PaymentSystem(PaymentSystemTypes system)
        {
            System = system;
        }

        public PaymentSystemTypes System { get; private set; }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Вы оплатили с помощью {System}");
            Console.WriteLine($"Проверка платежа через {System}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
