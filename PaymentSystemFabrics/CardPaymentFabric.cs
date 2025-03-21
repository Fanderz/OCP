﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.PaymentSystemFabrics
{
    class CardPaymentFabric : PaymentSystemFabric
    {
        public override IPaymentSystem Create()
        {
            return new Card();
        }
    }
}
