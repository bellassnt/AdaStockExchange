using AdaStockExchange.Domain.Models;
using System;
using Xunit;

namespace AdaStockExchange.Services.Tests
{
    public class MarketOrderTest
    {
        //private readonly IMarketOrderService _service;

        //public MarketOrderTest(IMarketOrderService service)
        //{
        //    _service = service;
        //}

        [Theory]
        [InlineData("2022-09-27 08:00:00", false)]
        [InlineData("2022-09-27 09:30:00", true)]
        [InlineData("2022-09-27 12:00:00", true)]
        [InlineData("2022-09-27 16:00:00", false)]
        [InlineData("2022-09-27 17:30:00", false)]
        public void MarketOrderDuringStandardOrAfterHoursTradingSessionTest(DateTime marketOrderTime, bool expectedResult)
        {
            // Arrange
            var marketOrder = new MarketOrder
            {
                Time = marketOrderTime
            };

            var _service = new MarketOrderService();
            
            // Act
            var result = _service.ValidateMarketOrderTime(marketOrder);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}