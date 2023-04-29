using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace GoogleRecaptchaWebAPI.Models
{
    public class GoogleRecaptchaAPIRequest
    {
        [JsonProperty(PropertyName = "secret")]
        [Required(ErrorMessage = "Secret is required.")]
        public string? Secret { get; set; }
        [JsonProperty(PropertyName = "response")]
        [Required(ErrorMessage = "Response is required.")]
        public string? Response { get; set; }
        [JsonProperty(PropertyName = "remoteip")]
        public string? Remoteip { get; set; }
    }
}
