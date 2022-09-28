using AdaStockExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaStockExchange.Services
{
    public interface IMarketOrderService
    {
        bool ValidateMarketOrderTime(MarketOrder marketOrder);
    }
}
