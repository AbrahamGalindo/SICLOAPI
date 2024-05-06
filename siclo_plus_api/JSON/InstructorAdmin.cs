using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class InstructorAdmin
    {
        public static string GenerateJSONForPostInstructorAdmin()
        {
            return @"{""name"": ""InstructorTestAPI" + Helper.GenerateLetters(4) + @""",""email"": ""email" + Helper.GenerateLetters(4) + @"@testin.test"",""phone"": ""552215" + Helper.GenerateRandomNumber(1111, 9999) + @""",""gender"": ""male"",""birthday"": ""1993-07-16"",""bio"": ""Bio for test"", ""brightcove"": ""123456789"",""appleMusic"": ""123456789"",""status"": ""true"",""philosophy"": ""Testing automation API"",""fitness"": ""Fitness for test"",""music"": ""Test Music"",""activities"": ""Testing"",""surprise"": ""Testing"",""inspiration"": ""Test""}";
        }
        public static string GenerateJSONForPutInstructorAdmin()
        {
            return @"{""name"": ""InstructorTestAPI" + Helper.GenerateLetters(4) + @""",""email"": ""email" + Helper.GenerateLetters(4) + @"@testin.test"",""phone"": ""552215" + Helper.GenerateRandomNumber(1111, 9999) + @""",""gender"": ""male"",""birthday"": ""1993-07-16"",""bio"": ""Bio for test"", ""brightcove"": ""123456789"",""appleMusic"": ""123456789"",""status"": ""true"",""philosophy"": ""Testing automation API"",""fitness"": ""Fitness for test"",""music"": ""Test Music"",""activities"": ""Testing"",""surprise"": ""Testing"",""inspiration"": ""Test""}";
        }
    }
}
