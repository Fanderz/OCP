namespace OCP.PaymentSystemFabrics
{
    class WebMoneyPaymentFactory : PaymentSystemFactory
    {
        public override IPaymentSystem Create()
        {
            return new WebMoney();
        }
    }
}
