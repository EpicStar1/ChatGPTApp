namespace ChatGPTApp.Models.ViewModels
{
    public class ChatRequest
    {
        public string model { get; set; }
        public Message[] messages { get; set; }
    }
}
