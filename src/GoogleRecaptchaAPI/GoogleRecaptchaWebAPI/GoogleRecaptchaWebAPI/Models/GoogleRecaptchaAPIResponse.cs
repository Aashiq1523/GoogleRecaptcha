using Newtonsoft.Json;

namespace GoogleRecaptchaWebAPI.Models
{
    public class GoogleRecaptchaAPIResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
        [JsonProperty(PropertyName = "challenge_ts")]
        public string? ChallengeTs { get; set; }
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        [JsonProperty(PropertyName = "error-codes")]
        public IList<string>? Errorcodes { get; set; }
    }
}
