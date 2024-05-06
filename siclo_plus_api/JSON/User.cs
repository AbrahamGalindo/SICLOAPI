using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class User
    {
        public static string GenerateJSONForPostUser()
        {
            return @"{""firstname"": ""Juannto"+Helper.GenerateLetters(3)+@""",""lastname"": ""Doe"",""email"": ""someemail" + Helper.GenerateLetters(5) + @"@testing.com"",""birthday"": ""1990-10-12"",""lada"": ""+52"",  ""phone"": ""5513669676"", ""gender"": ""male"",""country"": ""MX"",""weight"": 30,""height"": 300,""accountType"": 1,""password"": ""password123"",""repeat_password"": ""password123""}";
        }

        public static string GenerateJSONForPutUser()
        {
            return @"{""firstname"": ""Javier"",""lastname"": ""Lopez"",""birthday"": ""1990-10-12"",""lada"": ""+52"",  ""phone"": ""5513669676"", ""gender"": ""male"",""country"": ""MX"",""weight"":" + Helper.GenerateRandomNumber(10, 99) + @",""height"": 300}";
        }
        public static string GenerateJSONForPostUserSubscription()
        {
            return @"{""lastest_receipt"": ""Today""}";
        }

        
    }
}
