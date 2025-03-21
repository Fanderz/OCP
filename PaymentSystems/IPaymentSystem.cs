using System;

namespace OCP
{
    interface IPaymentSystem
    {
        PaymentSystemTypes System { get; }
    }
}
