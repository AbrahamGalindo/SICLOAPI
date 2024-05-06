using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
   public class Brightcove
    {
        //01_Post_brightcove
        public static string GenerateJSONForPostVideos()
        {
            return @"{""timestamp"": 1423840514446,""account_id"": ""775205503001"",""event"": ""video-change"",""video"": ""4020894387001"",""version"": 26}";
        }
    }
}
