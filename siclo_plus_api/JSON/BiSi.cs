using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class BiSi
    {
        public static string GenerateJSONForPostBisi()
        {
            return @"{""serialNumber"": " + Helper.PutQuotes(Helper.CreateSerial()) + "}";
        }
        public static string GenerateJSONForPutBisi()
        {
            return @"{""serialNumber"": " + Helper.PutQuotes(Helper.CreateSerial()) + "}";
        }
    }
}
