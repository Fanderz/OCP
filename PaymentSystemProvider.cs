using OCP.PaymentSystemFabrics;
using System;
using System.Collections.Generic;

namespace OCP
{
    class PaymentSystemProvider
    {
        private Dictionary<string, PaymentSystemFabric> _fabrics;

        public PaymentSystemProvider()
        {
            _fabrics = new Dictionary<string, PaymentSystemFabric>();

            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.QIWI)}", new QiwiPaymentFabric());
            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.WebMoney)}", new WebMoneyPaymentFabric());
            _fabrics.Add($"{Convert.ToInt32(PaymentSystemTypes.Card)}", new CardPaymentFabric());
        }

        public IEnumerable<string> FabricIds => _fabrics.Keys;

        public PaymentSystemFabric GetPaymentSystemFabric(string systemId)
        {
            return _fabrics[systemId];
        }
    }
}
