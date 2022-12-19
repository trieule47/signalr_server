using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
       // public async Task SendMessage(string user, string message)
       // {
//await Clients.All.SendAsync("ReceiveMessage", user, message);
      //  }

        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }

    public class Message
    {
        public string user { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public dynamic date { get; set; }
    }
}