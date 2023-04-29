/*
Title: VerifyRecaptchAPI Controller
CreatedBy: Mohamed Aashiq
CreatedOn: 04/29/2023
Title:
    This class file contains VerifyRecaptchAPI Controller to validate the google recaptcha.
Modifications:
*/

using GoogleRecaptchaWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GoogleRecaptchaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VerifyRecaptchAPIController : ControllerBase
    {
        [HttpPost]
        public GoogleRecaptchaAPIResponse ValidateToken(GoogleRecaptchaAPIRequest request)
        {
            GoogleRecaptchaAPIResponse? response = null;
            if (request != null)
            {
                var requestParams = new Dictionary<string, string> {
                        { "secret", request.Secret },
                        { "response", request.Response },
                        { "remoteip", request.Remoteip }
                    };
                using (HttpClient client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(requestParams);
                    var apiresponse = client.PostAsync("https://www.google.com/recaptcha/api/siteverify", content).Result;
                    var responseString = apiresponse.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrWhiteSpace(responseString))
                    {
                        response = JsonConvert.DeserializeObject<GoogleRecaptchaAPIResponse>(responseString);
                    }
                }
            }
            return response;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
