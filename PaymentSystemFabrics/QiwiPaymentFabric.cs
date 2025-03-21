namespace OCP.PaymentSystemFabrics
{
    class QiwiPaymentFabric : PaymentSystemFabric
    {
        public override IPaymentSystem Create()
        {
            return new Qiwi();
        }
    }
}
