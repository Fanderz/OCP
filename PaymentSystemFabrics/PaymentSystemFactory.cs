namespace OCP.PaymentSystemFabrics
{
    abstract class PaymentSystemFactory
    {
        public abstract IPaymentSystem Create();
    }
}
