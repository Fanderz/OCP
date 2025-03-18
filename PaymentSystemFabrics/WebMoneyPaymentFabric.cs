using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.PaymentSystemFabrics
{
    class WebMoneyPaymentFabric : PaymentSystemFabric
    {
        public override PaymentSystem Create()
        {
            return new WebMoney(PaymentSystemTypes.WebMoney);
        }
    }
}
