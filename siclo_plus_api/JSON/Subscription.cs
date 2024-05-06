using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class Subscription
    {
        public static string GenerateJSONForPostSubscription()
        {
            return @"{""planId"": ""f8235b99-9047-4c22-9636-557abe97847a"",""paymentMethodId"": ""pm_1IciH7AvAHnh79J7O2sd6Uso""}";
        }
                public static string GenerateJSONForPutSubscription()
        {
            return @"{""payment_method_id"": ""pm_1IciH7AvAHnh79J7O2sd6Uso""}";
        }

        public static string GenerateJSONForDeleteSubscription(string subscriptionId)
        {
            return @"{""subscriptionId"": " + Helper.PutQuotes(subscriptionId) +"}";
        }
    }
}
