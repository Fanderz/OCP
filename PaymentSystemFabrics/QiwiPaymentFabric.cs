namespace OCP.PaymentSystemFabrics
{
    class QiwiPaymentFabric : PaymentSystemFabric
    {
        public override PaymentSystem Create()
        {
            return new Qiwi(PaymentSystemTypes.QIWI);
        }
    }
}
