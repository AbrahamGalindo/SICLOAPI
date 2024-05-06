using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class TutorialAdmin
    {
        public static string GenerateJSONForPostTutorial()
        {
            char separator = Path.DirectorySeparatorChar;
            string path = $"{separator}Source{separator}Documents{separator}barre.jpg";
            string image = "@" + Helper.PutQuotes(Helper.GetCurrentPath(@path));
            return @"{""title"": ""Tutorial for testing" + Helper.GenerateLetters(4) + @""",""thumbnail"":""https://packages.siclo.plus/bisi/videos/ajustes_de_bisi/1_Como+ajustar+la+altura+del+asiento_1.jpg"",""url"": ""https://packages.siclo.plus/bisi/videos/ajustes_de_bisi/1_Como+ajustar+la+altura+del+asiento_2.mp4y"",""sort"": 0,""category"": ""Testing""}";
        }
    }
}
