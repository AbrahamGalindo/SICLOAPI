using Newtonsoft.Json;
using RestSharp;
using siclo_plus_api.Constants;
using siclo_plus_api.Request;
using siclo_plus_api.Steps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace siclo_plus_api.Helpers
{
    public class Helper
    {
        public const int tHigh = 5000;
        public const int tMedium = 3000;
        public const int tLow = 2000;
        public static IRestResponse response;
        public static void Wait(int time) => Thread.Sleep(time);

        public static string GetCurrentPath(string file)
        {
            char separator = Path.DirectorySeparatorChar;
            string currentDir = Directory.GetCurrentDirectory();
            string parentDir = Directory.GetParent(currentDir).FullName;
            parentDir = parentDir + $"{separator}{file}";
            return parentDir;

        } //=> Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName).Parent.FullName, $"siclo_plus_api{file}");
        public static string RemoveCharacter(string text, string character) => text.Replace(character, "");
        public static string GetCurrentDate()
        {
            DateTime today = DateTime.Today;
            return today.ToString("dd-MM-yyyy").Replace("-", "/"); ;
        }
        public static string ConvertToCapitalLetters(string text) => text.ToUpper();
        public static string ConvertToLowLetters(string text) => text.ToLower();

        public static int GenerateRandomNumber(int initial, int final) => new Random().Next(initial, final);
        public static string GenerateAdvisorCode() => GenerateLetters(1) + GenerateRandomNumber(1000, 9999).ToString();
        public static string GenerateLetters(int lettersNumber)
        {
            string letters = "";
            for (int i = 0; i < lettersNumber; i++)
            {
                letters = letters + ((char)(((int)'A') + GenerateRandomNumber(0, 25))).ToString();
            }
            return letters;
        }
        public static string PutQuotes(string item) => item = "\"" + item + "\"";
        public static string GenerateDateOfBirth() => GenerateRandomNumber(1, 30).ToString() + "-" + GenerateRandomNumber(1, 12).ToString() + "-" + GenerateRandomNumber(1950, 2020).ToString();
        public static string GenerateExpirationDate()
        {
            DateTime year = DateTime.Today;
            return GenerateRandomNumber(1, 30).ToString() + "-" + GenerateRandomNumber(1, 12).ToString() + "-" + (year.Year + 1).ToString();
        }
        public static string CreateSerial()
        {
            string serial = "275" + GenerateLetters(3).ToUpper() + GenerateRandomNumber(10, 99) + GenerateLetters(3).ToUpper() + GenerateRandomNumber(11111, 99999) + "MX";
            if (!serial.Length.Equals(18))
            {
                for (int i = 0; i < 100; i++)
                {
                    serial = "275" + GenerateLetters(3).ToUpper() + GenerateRandomNumber(10, 99) + GenerateLetters(3).ToUpper() + GenerateRandomNumber(11111, 99999) + "MX";
                    if (serial.Length.Equals(18))
                    {
                        break;
                    }
                }
            }
            return serial;
        }

        public static string GetItemFromResponse(string item, string response, string test)
        {
            dynamic jsonObj = JsonConvert.DeserializeObject(response);
            if (test.Equals("videos"))
            {
                jsonObj = jsonObj["videos"];
                jsonObj = jsonObj[0];
            }
            if (test.Equals("["))
            {
                jsonObj = jsonObj[0];
            }
            if (test.Equals("]"))
            {
                jsonObj = jsonObj[1];
            }
            return jsonObj[item].ToString();
        }

        public static void CreateJsonResponseFile()
        {
            char separator = Path.DirectorySeparatorChar;
            StreamWriter sw = new StreamWriter(Helper.GetCurrentPath($"TestResults{separator}{Base.scenarioName}_{Base.spectedResponse}.txt"));
            string json = Rest.response.Content.ToString();
            if (json.Equals(""))
            {
                json = "{No json response}";
            }
            sw.WriteLine(json);
            sw.Close();
        }
    }
}
