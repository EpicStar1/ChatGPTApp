using static OpenAI.ChatGpt.Models.ChatCompletion.ChatCompletionResponse;

namespace ChatGPTApp.Models
{
    public class ChatResponse
    {
        public string id { get; set; }
        public string _object { get; set; }
        public int created { get; set; }
        public Choice[] choices { get; set; }
        public Usage usage { get; set; }
        public string BotReply { get; set; }
    }
}
