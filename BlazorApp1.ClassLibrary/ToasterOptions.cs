using BlazorApp1.ClassLibrary.CustomConverters;
using BlazorApp1.ClassLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApp1.ClassLibrary
{
    public class ToastrOptions
    {
        [JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrPositionMethod>))]
        [JsonPropertyName("positionClass")]
        public ToastrPositionMethod PositionClass { get; set; }

        [JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrHideMethod>))]
        [JsonPropertyName("hideMethod")]
        public ToastrHideMethod HideMethod { get; set; }

        [JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrShowMethod>))]
        [JsonPropertyName("showMethod")]
        public ToastrShowMethod ShowMethod { get; set; }

/*        [JsonConverter(typeof(CustomEnumDescriptionConverter<>))]
*/        [JsonPropertyName("closeButton")]
        public bool CloseButton {  get; set; }

/*        [JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrPositionMethod>))]
*/        [JsonPropertyName("hideDuration")]
        public int HideDuration { get; set; }
    }
}
