namespace ChatGPTApp.Models
{
    public class ChatRequests
    {
        public string model { get; set; }
        public Message[] messages { get; set; }

        public string UserInput { get; set; }
    }
}
