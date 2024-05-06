using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class BrandAdmin
    {
        public static string GenerateJSONForPostBrandAdmin(string name, string description, string color)
        {
            return @"{""name"": " + Helper.PutQuotes(name+Helper.GenerateLetters(5)) + @",""description"":" + Helper.PutQuotes(description) + @",""color"":" + Helper.PutQuotes(color) + "}";
        }
        public static string GenerateJSONForPostBrandAdminBadRequest(string name, string description, string color)
        {
            return @"{""name"": " + Helper.PutQuotes(name) + @",""descripti"":" + Helper.PutQuotes(description) + @",""color"":" + Helper.PutQuotes(color) + @",""status"":" + "true" + "}";
        }
        public static string GenerateJSONForPutBrandAdmin(string name, string description, string color)
        {
            return @"{""name"": " + Helper.PutQuotes(name + Helper.GenerateLetters(5)) + @",""description"":" + Helper.PutQuotes(description) + @",""color"":" + Helper.PutQuotes(color) + "}";
        }
        public static string GenerateJSONForPutBrandAdminBadRequest(string name, string description, string color)
        {
            return @"{""name"": " + Helper.PutQuotes(name + Helper.GenerateLetters(5)) + @",""des"":" + Helper.PutQuotes(description) + @",""color"":" + Helper.PutQuotes(color) + "}";
        }

        
    }
}
