using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class BiSiAdmin
    {
        public static string GenerateJSONForPostBisiAdmin(string email)
        {
            return @"{""email"": " + Helper.PutQuotes(email) + @",""serialNumber"":" + Helper.PutQuotes(Helper.CreateSerial()) + "}";
        }
        public static string GenerateJSONForPutBisiAdmin(string email)
        {
            return @"{""email"": " + Helper.PutQuotes(email) + @",""serialNumber"":" + Helper.PutQuotes(Helper.CreateSerial()) + @",""active"":true}";
        }
        public static string GenerateJSONForPutBisiAdminBadRequest(string email)
        {
            return @"{""emal"": " + Helper.PutQuotes(email) + @",""serialNumber"":" + Helper.PutQuotes(Helper.CreateSerial()) + @",""active"":true}";
        }

    }
}
