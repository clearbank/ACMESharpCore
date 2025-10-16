using System;
using Newtonsoft.Json;

namespace ACMESharp.Protocol.Resources
{
    public class RenewalInfo
    {
        [JsonProperty("suggestedWindow")]
        public SuggestedWindow SuggestedWindow { get; set; }

        [JsonProperty("explanationURL")]
        public string ExplanationUrl { get; set; }
    }

    public class SuggestedWindow
    {
        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end")]
        public DateTimeOffset End { get; set; }
    }
}
