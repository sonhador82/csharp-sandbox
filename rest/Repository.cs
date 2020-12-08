using System.Text.Json.Serialization;
using System;

namespace rest
{
    public class Repository
    {
        [JsonPropertyName("name")]
        public string Name {set; get;}

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }

        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }        

        [JsonPropertyName("pushed_at")]
        public DateTime LastPushUtc { get; set; }
        public DateTime LastPush => LastPushUtc.ToLocalTime();
    }
}
