using ChatGPTApp.Models;
using ChatGPTApp.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;

namespace ChatGPTApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatGPTController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public ChatGPTController(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }

        [HttpPost]
        [Route("AskChatGPT")]
        public async Task<IActionResult> AskChatGPT([FromBody] string query)
        {
            try
            {

                HttpClient oClient = new HttpClient();
                ChatRequest oRequest = new ChatRequest();
                Message oMessage = new Message();
                StringBuilder result = new StringBuilder();

                oClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_appSettings.gptapiKey}");
                oRequest.model = "davinci:ft-personal:epicstar-model-2023-08-11-04-11-36"; //"gpt-3.5-turbo";
                oMessage.role = "user";
                oMessage.content = query;
                oRequest.messages = new Message[] { oMessage };

                string oReqJSON = JsonConvert.SerializeObject(oRequest);
                HttpContent oContent = new StringContent(oReqJSON, Encoding.UTF8, "application/json");

                HttpResponseMessage oResponseMessage = await oClient.PostAsync(_appSettings.chatURL, oContent);

                if (oResponseMessage.IsSuccessStatusCode)
                {
                    string oResJSON = await oResponseMessage.Content.ReadAsStringAsync();

                    if (oResJSON != null)
                    {
                        ChatResponse oResponse = JsonConvert.DeserializeObject<ChatResponse>(oResJSON);

                        if (oResponse != null)
                        {
                            foreach (Choice c in oResponse.choices)
                            {
                                result.Append(c.message.content);
                            }

                            HttpChatGPTResponse oHttpResponse = new HttpChatGPTResponse()
                            {
                                Success = true,
                                Data = result.ToString()
                            };

                            return Ok(oHttpResponse);
                        }
                        else
                        {
                            int statusCode = Convert.ToInt32(oResponseMessage.StatusCode);
                            return this.StatusCode(statusCode, "Oops! Try again.");
                        }
                    }
                    else
                    {
                        int statusCode = Convert.ToInt32(oResponseMessage.StatusCode);
                        return this.StatusCode(statusCode, "Oops! Try again.");
                    }
                }
                else
                {
                    int statusCode = Convert.ToInt32(oResponseMessage.StatusCode);
                    return this.StatusCode(statusCode, oResponseMessage.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(500,ex.Message);
            }
        }

        [HttpPost]
        [Route("TrainGPT")]
        public async Task<IActionResult> TrainGPT()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

    }
}
