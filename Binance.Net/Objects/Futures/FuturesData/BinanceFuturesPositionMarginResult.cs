﻿using Newtonsoft.Json;
using Binance.Net.Converters;
using Binance.Net.Enums;

namespace Binance.Net.Objects.Futures.FuturesData
{
    /// <summary>
    /// Result of the requested margin amount change
    /// </summary>
    public class BinanceFuturesPositionMarginResult
    {
        /// <summary>
        /// New margin amount
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Request response code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Maximum margin value
        /// NOTE: string type, because the value van be 'inf' (infinite)
        /// </summary>
        public string MaxNotionalValue { get; set; } = string.Empty;
        /// <summary>
        /// Direction of the requested margin change
        /// </summary>
        [JsonConverter(typeof(FuturesMarginChangeDirectionTypeConverter))]
        public FuturesMarginChangeDirectionType Type { get; set; }
    }

}
