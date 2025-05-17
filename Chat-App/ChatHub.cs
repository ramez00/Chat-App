using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat_App
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            
            Clients.All.newMessage(name, message);
        }
    }
}