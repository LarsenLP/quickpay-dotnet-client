using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Quickpay
{
    [JsonConverter(typeof (StringEnumConverter))]
    public enum AccountType
    {
        Any,
        Merchant,
        Reseller,
        Administrator,
        User
    }
}