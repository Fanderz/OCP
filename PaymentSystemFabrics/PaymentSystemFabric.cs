namespace OCP.PaymentSystemFabrics
{
    abstract class PaymentSystemFabric
    {
        public abstract IPaymentSystem Create();
    }
}
