using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
   public class UserProfile
    {
        public static string GenerateJSONForPostProfile()
        {
            return @"{""firstname"": ""Jonh"",""lastname"": ""Doe"",""birthday"": ""1990-10-12"", ""gender"": ""male"",""weight"": 30,""height"": 300}";
        }
    }
}
