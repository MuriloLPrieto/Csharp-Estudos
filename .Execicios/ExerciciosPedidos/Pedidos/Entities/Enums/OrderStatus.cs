using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities.Enums
{
    internal enum OrderStatus : int
    {
        Pending_Payment,
        Processing,
        Shipped,
        Delivered
    }
}
