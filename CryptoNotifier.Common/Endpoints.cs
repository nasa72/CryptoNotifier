﻿namespace CryptoNotifier.Common
{
    public sealed class CoinbaseEndpoints
    {
        public const string DEFAULT_BASE_URL = "https://api.coinbase.com/";
        public const string DEFAULT_API_VERSION = "v2/";
        public const string DEFAULT_API_DATE = "2017-11-30";

        public const string User = "user";
        public const string Accounts = "accounts";
        public const string ExchangeRates = "exchange-rates";
        public const string SpotPrice = "prices/{origin}-{destination}/spot";
    }
}
