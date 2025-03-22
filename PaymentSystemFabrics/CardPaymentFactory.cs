namespace OCP.PaymentSystemFabrics
{
    class CardPaymentFactory : PaymentSystemFactory
    {
        public override IPaymentSystem Create()
        {
            return new Card();
        }
    }
}
