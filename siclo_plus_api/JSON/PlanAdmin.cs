using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
   public class PlanAdmin
    {
        public static string GenerateJSONForPostPlanAdmin()
        {
            return @"{""name"": ""Siclo + monthly plan"",""description"": ""The best training concepts in one place, Unlimited Indoor Cycling, Cardio, Functional, Yoga, Box and Barre classes. Live and On Demand"",""type"": ""service"",""active"": true,""currency"": ""mxn"",""unitAmount"": 140,""recurringInterval"": ""month"",""recurringIntervalCount"": 12,""recurringTrialPeriodDay"": 7,""storeId"": ""c2281c47-c0c2-4582-9538-d980a10035ca""}";
        }
        public static string GenerateJSONForPutPlanAdmin() {
            return @"{""name"": ""Siclo + monthly plan"",""description"": ""The best training concepts in one place, Unlimited Indoor Cycling, Cardio, Functional, Yoga, Box and Barre classes. Live and On Demand"",""active"": true,""recurringTrialPeriodDay"": 7}";
        }
    }
}
