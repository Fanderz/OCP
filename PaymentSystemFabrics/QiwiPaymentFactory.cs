namespace OCP.PaymentSystemFabrics
{
    class QiwiPaymentFactory : PaymentSystemFactory
    {
        public override IPaymentSystem Create()
        {
            return new Qiwi();
        }
    }
}
