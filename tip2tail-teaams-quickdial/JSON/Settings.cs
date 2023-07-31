using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tip2tail_teaams_quickdial.JSON
{
    public partial class Settings
    {
        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonProperty("order")]
        public List<Guid> Order { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public partial class Settings
    {
        public static Settings FromJson(string json) => JsonConvert.DeserializeObject<Settings>(json, tip2tail_teaams_quickdial.JSON.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Settings self) => JsonConvert.SerializeObject(self, tip2tail_teaams_quickdial.JSON.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
