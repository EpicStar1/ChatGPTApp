using ChatGPTApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using System.Text;
using OpenAI;
using Tensorflow;
using Newtonsoft.Json;
using static ChatGPTApp.Controllers.GptController;
using System.Text.Json.Nodes;
using System;
using RestSharp;

namespace ChatGPTApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GptController : ControllerBase
    {
        private const string ModelPath = "path/to/your/fine_tuned_gpt2";
        private readonly AppSettings _appSettings;
        public GptController(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }

        [HttpPost]
        [Route("ChatGPTDavinciText")]
        public async Task<IActionResult> ChatGPTDavinciText([FromBody] string query)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                var openai = new OpenAIAPI(_appSettings.gptapiKey);
                CompletionRequest completionRequest = new CompletionRequest();
                completionRequest.Prompt=query;
                completionRequest.Model = "davinci:ft-personal:epicstar-model-2023-08-11-04-11-36";//OpenAI_API.Models.Model.AdaText;  //text-davinci-003 or text-ada-001
                completionRequest.MaxTokens = 100; //Adjust the response length as needed


                CompletionResult completion = await openai.Completions.CreateCompletionAsync(completionRequest);    //Completion (Legacy)

                if (completion != null && completion.Completions != null)
                {
                    foreach (var comp in completion.Completions)
                    {
                        result.Append(comp.Text);
                    }

                    return Ok(result.ToString());
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }           
            
        }

        [HttpPost]
        [Route("ChatGPTTurbo")]
        public async Task<IActionResult> ChatGPTTurbo([FromBody] string query)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                var openai = new OpenAIAPI(_appSettings.gptapiKey);              

                ChatRequest oRequest = new ChatRequest();
                ChatMessage oMessage = new ChatMessage();
                List<ChatMessage> messages = new List<ChatMessage>();                

                oRequest.Model = "gpt-3.5-turbo";
                oMessage.Role = ChatMessageRole.User;
                oMessage.Content = query;
                messages.Add(oMessage);
                oRequest.Messages = new List<ChatMessage>(messages);
                oRequest.MaxTokens = 7; //Adjust the response length as needed

                ChatResult chatResult = await openai.Chat.CreateChatCompletionAsync(oRequest); //Chat completion

                if (chatResult != null && chatResult.Choices != null)
                {
                    foreach (var choice in chatResult.Choices)
                    {
                        result.Append(choice);
                    }

                    return Ok(result.ToString());
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }

        }


        [HttpGet]
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
