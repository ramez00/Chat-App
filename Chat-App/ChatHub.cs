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

        public void SendGroup(string name, string message,string grpName)
        {

            Clients.Group(grpName).messageGrp(message,name,grpName);
        }

        public void joinGroup(string name, string grpName)
        {
            Groups.Add(Context.ConnectionId, grpName);

            Clients.OthersInGroup(grpName).newMember(name, grpName);
        }
    }
}