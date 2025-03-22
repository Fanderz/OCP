using System;
using System.Collections.Generic;
using OCP.PaymentSystemFabrics;

namespace OCP
{
    class PaymentSystemProvider
    {
        private readonly Dictionary<string, PaymentSystemFactory> _fabrics;

        public PaymentSystemProvider()
        {
            _fabrics = new Dictionary<string, PaymentSystemFactory>();

            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.QIWI)}", new QiwiPaymentFactory());
            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.WebMoney)}", new WebMoneyPaymentFactory());
            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.Card)}", new CardPaymentFactory());
        }

        public IEnumerable<string> FabricIds => _fabrics.Keys;

        public PaymentSystemFactory GetPaymentSystemFabric(string systemId)
        {
            return _fabrics[systemId];
        }
    }
}
