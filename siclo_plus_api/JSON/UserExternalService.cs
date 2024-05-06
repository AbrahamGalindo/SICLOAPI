using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class UserExternalService
    {
        public static string GenerateJSONForPostUserExternalServices()
        {
            return @"{""service"": ""stripe" + Helper.GenerateLetters(5) + @""",""additionalInformation"": { }}";
        }
    }
}
