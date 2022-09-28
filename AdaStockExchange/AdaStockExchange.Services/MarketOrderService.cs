using AdaStockExchange.Domain.Models;

namespace AdaStockExchange.Services
{
    public class MarketOrderService : IMarketOrderService
    {
        public const int OPENING_TRADING_SESSION_HOUR = 9;
        public const int OPENING_TRADING_SESSION_MINUTE = 30;
        public const int CLOSING_TRADING_SESSION_TIME = 16;

        public bool ValidateMarketOrderTime(MarketOrder marketOrder)
        {
            if (marketOrder.Time.Hour < OPENING_TRADING_SESSION_HOUR ||
                marketOrder.Time.Hour == OPENING_TRADING_SESSION_HOUR && marketOrder.Time.Minute < OPENING_TRADING_SESSION_MINUTE ||
                marketOrder.Time.Hour >= CLOSING_TRADING_SESSION_TIME)
                return false;
                       
            return true;
        }
    }
}