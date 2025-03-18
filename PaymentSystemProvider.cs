using OCP.PaymentSystemFabrics;
using System.Collections.Generic;

namespace OCP
{
    class PaymentSystemProvider
    {
        private Dictionary<int, PaymentSystemFabric> _fabrics;

        public PaymentSystemProvider()
        {
            _fabrics = new Dictionary<int, PaymentSystemFabric>();

            _fabrics.Add(1, new QiwiPaymentFabric());
            _fabrics.Add(2, new WebMoneyPaymentFabric());
            _fabrics.Add(3, new CardPaymentFabric());
        }

        public IEnumerable<int> FabricIds => _fabrics.Keys;

        public PaymentSystemFabric GetPaymentSystemFabric(int systemId)
        {
            return _fabrics[systemId];
        }
    }
}
