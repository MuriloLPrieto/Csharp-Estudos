using System;
using System.Collections.Generic;
using System.Globalization;

namespace Enumeracao.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
