using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class PlayListAdmin
    {
        public static string GenerateJSONForPostPlaylistAdmin(string videoId, string instructorId, string brandId)
        {
            return @"{""title"": ""PlayListForTesting"",""subtitle"": ""PlayListForTestingAPI"",""summary"": ""This is just for testing"",""intensity"": 1,""items"": [{""videoId"": " + Helper.PutQuotes(videoId) + @",""instructorId"":  " + Helper.PutQuotes(instructorId) + @",""brandId"":  " + Helper.PutQuotes(brandId) + @",""order"": 1}],""active"": true}";
        }
        public static string GenerateJSONForPutPlaylistAdmin()
        {
            return @"{""title"": ""Rueda con Eugenia Carroll"",""subtitle"": ""Los mejores videos de Rueda"",""summary"": ""This is just for testing"",""period"": ""day"",""duration"": 10,""intensity"": 1}";
        }
        public static string GenerateJSONForPutPlaylistItemsAdmin(string videoId, string instructorId, string brandId)
        {
            return @"[{""videoId"": " + Helper.PutQuotes(videoId) + @",""instructorId"":  " + Helper.PutQuotes(instructorId) + @",""brandId"": " + Helper.PutQuotes(brandId) + @",""order"": 2}]";
        }
    }
}
