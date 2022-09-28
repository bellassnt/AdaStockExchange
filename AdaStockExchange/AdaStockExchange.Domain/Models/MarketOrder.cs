using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaStockExchange.Domain.Models
{
    public class MarketOrder
    {
        public int OrderId { get; set; }

        public int ClientId { get; set; }

        public string Ticker { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public DateTime Time { get; set; }
    }
}
