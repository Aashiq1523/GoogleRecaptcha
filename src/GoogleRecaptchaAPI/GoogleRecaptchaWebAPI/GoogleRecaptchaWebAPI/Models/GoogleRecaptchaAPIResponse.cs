/*
Title: GoogleRecaptchaAPIResponse Class
CreatedBy: Mohamed Aashiq
CreatedOn: 04/29/2023
Title:
    This class file contains google recaptcha api response fields.
Modifications:
*/

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
