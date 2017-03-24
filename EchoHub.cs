using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Line2.Hubs
{
    [HubName("Echo")]
    public class EchoHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(Data data)
        {
            Clients.All.Receive(data);
        }
    }

    public class Data
    {
        public string User { get; set; }
        public string Message { get; set; }
    }
}