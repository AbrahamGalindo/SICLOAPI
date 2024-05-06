using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class SliderAdmin
    {
        public static string GenerateJSONForPostSliderAdmin()
        {
            return @"{""title"": ""Alas negras"",""subtitle"": ""Pidelas!"",""helper_text"": """",""priority"": 8,""type"": 8,""action_type"": 2,""data_type"": 0 ,""image"": ""https://shop.siclo.com/pub/media/catalog/product/cache/1c976894a355b7851ee23e6e5cadd1e6/s/i/siclo-alas-nuevas-negras1.jpg"",""reference_url"": ""https://shop.siclo.com/mx/nuevas-alas-negras"",""reference_text"": """", ""country"": ""MX""}";
        }
        public static string GenerateJSONForPutSliderAdmin()
        {
            return @"{""title"": ""Alas negras"",""subtitle"": ""Pidelas ya!"",""helper_text"": """",""priority"": 8,""type"": 8,""action_type"": 2,""data_type"": 0 ,""image"": ""https://shop.siclo.com/pub/media/catalog/product/cache/1c976894a355b7851ee23e6e5cadd1e6/s/i/siclo-alas-nuevas-negras1.jpg"",""reference_url"": ""https://shop.siclo.com/mx/nuevas-alas-negras"",""reference_text"": """", ""country"": ""MX""}";
        }
        public static string GenerateJSONForDeleteSliderAdmin()
        {
            return @"{""id"": ""22eb627e-27fa-4f2a-9ddc-6d0807e05d43""}";
        }
        public static string GenerateJSONForPostPrioritySliderAdmin()
        {
            return @"{""id"": ""22eb627e-27fa-4f2a-9ddc-6d0807e05d43""}";
        }

    }
}
