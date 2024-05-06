using RestSharp;
using siclo_plus_api.Helpers;
using siclo_plus_api.Steps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace siclo_plus_api.Request
{
    public class Rest
    {
        #region "Request"
        public RestClient restClient;
        public RestRequest restRequest;
        public static IRestResponse response;
        public static HttpStatusCode statusCode;
        public static int status;

        public void PostRequest(string jsonString, string url, string token, bool data)
        {
            Console.WriteLine("current url:....." + url);
            restClient = new RestClient(url);
            restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddBody(jsonString);
            if (!token.Equals(""))
            {
                restRequest.AddHeader("Authorization", token);
            }
            if (!jsonString.Equals(""))
            {
                if (data.Equals(true))
                {
                    char separator = Path.DirectorySeparatorChar;
                    string path = $"{separator}Source{separator}Documents{separator}barre.jpg";
                    restRequest.AddHeader("Content-Type", "multipart/form-data");
                    restRequest.AddHeader("Accept", "*/*");
                    restRequest.AddFile("file", Helper.GetCurrentPath(@path), "image/jpeg");
                }
                else
                {
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddBody(jsonString);
                }
                if (jsonString.Contains("service") || jsonString.Contains("paymentMethodId"))
                {
                    restRequest.AddHeader("Store-Code", "c2281c47-c0c2-4582-9538-d980a10035ca");
                    restRequest.AddHeader("Accept-Language", "en");
                }
            }
            response = restClient.Execute(restRequest);
            statusCode = response.StatusCode;
            status = (int)statusCode;
        }

        public void DeleteRequest(string jsonString, string url, string token)
        {
            Console.WriteLine("current url:....." + url);
            restClient = new RestClient(url);
            restRequest = new RestRequest(Method.DELETE);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Authorization", token);
            if (!jsonString.Equals(""))
            {
                restRequest.AddBody(jsonString);
            }
            if (jsonString.Contains("subscriptionId"))
            {
                restRequest.AddHeader("Store-Code", "c2281c47-c0c2-4582-9538-d980a10035ca");
                restRequest.AddHeader("Accept-Language", "en");
            }
            response = restClient.Execute(restRequest);
            statusCode = response.StatusCode;
            status = (int)statusCode;
        }

        public void PutRequest(string jsonString, string url, string token, bool data)
        {
            Console.WriteLine("current url:....." + url);
            restClient = new RestClient(url);
            restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Authorization", token);

            if (!jsonString.Equals(""))
            {
                if (data.Equals(true))
                {
                    char separator = Path.DirectorySeparatorChar;
                    string path = $"{separator}Source{separator}Documents{separator}barre.jpg";
                    restRequest.AddHeader("Content-Type", "multipart/form-data");
                    restRequest.AddHeader("Accept", "*/*");
                    restRequest.AddFile("file", Helper.GetCurrentPath(@path), "image/jpeg");
                }
                else
                {
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddBody(jsonString);
                }
                if (jsonString.Contains("payment_method_id"))
                {
                    restRequest.AddHeader("Store-Code", "c2281c47-c0c2-4582-9538-d980a10035ca");
                    restRequest.AddHeader("Accept-Language", "en");
                }
            }
            response = restClient.Execute(restRequest);
            statusCode = response.StatusCode;
            status = (int)statusCode;
        }

        public void GetRequest(string url, string token, string test)
        {
            Console.WriteLine("current url:....." + url);
            restClient = new RestClient(url);
            restRequest = new RestRequest(Method.GET);
            // restRequest.RequestFormat = DataFormat.Json;

            if (test.Equals("plan"))
            {
                restRequest.AddHeader("Store-Code", "c2281c47-c0c2-4582-9538-d980a10035ca");
                restRequest.AddHeader("Accept-Language", "en");
            }
            if (!test.Equals("403"))
            {
                restRequest.AddHeader("Authorization", token);
            }
            if (test.Equals("slider"))
            {
                restRequest.AddParameter("page", 1);
                restRequest.AddParameter("limit", 20);
                restRequest.AddParameter("country", "MX");
            }
            response = restClient.Execute(restRequest);
            statusCode = response.StatusCode;
            status = (int)statusCode;
        }

        public void PatchRequest(string jsonString, string url, string token)
        {
            Console.WriteLine("current url:....." + url);
            restClient = new RestClient(url);
            restRequest = new RestRequest(Method.PATCH);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Authorization", token);
            restRequest.AddBody(jsonString);
            response = restClient.Execute(restRequest);
            statusCode = response.StatusCode;
            status = (int)statusCode;
        }
        #endregion
        public bool HasCorrectResponse(int code) => status.Equals(code);
    }
}
