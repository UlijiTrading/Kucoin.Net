﻿using Newtonsoft.Json;

namespace Kucoin.Net.Objects.Futures.Socket
{
    /// <summary>
    /// Result of updating risk limit level
    /// </summary>
    public class KucoinPositionRiskAdjustResultUpdate
    {
        /// <summary>
        /// Successfull or not
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Current risk limit level
        /// </summary>
        public bool RiskLimitLevel { get; set; }
        /// <summary>
        /// Failure reason
        /// </summary>
        [JsonProperty("msg")]
        public string Message { get; set; } = string.Empty;
    }
}
