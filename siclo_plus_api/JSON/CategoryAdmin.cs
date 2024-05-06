using siclo_plus_api.Helpers;

namespace siclo_plus_api.JSON
{
    public class CategoryAdmin
    {
        //01_Post_category_Admin
        public static string GenerateJSONForPostCategoryAdmin()
        {
            return @"{""name"": ""Category for testing new"+ Helper.GenerateLetters(3) +@""",""description"": ""This is just test"", ""status"": true}";
        }

        public static string GenerateJSONForPutCategoryAdmin(string name, string description)
        {
            return @"{""name"": " + Helper.PutQuotes(name + Helper.GenerateLetters(5)) + @",""description"":" + Helper.PutQuotes(description) + @",""status"": true}";

        }
    }
}