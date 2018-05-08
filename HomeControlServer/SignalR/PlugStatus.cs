using HomeControlServer.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;

namespace HomeControlServer.SignalR
{
    public class PlugStatus
    {
        private readonly static Lazy<PlugStatus> _instance = new Lazy<PlugStatus>(() => new PlugStatus(GlobalHost.ConnectionManager.GetHubContext<PlugStatusHub>().Clients));

        private IHubConnectionContext<dynamic> Clients { get; set; }

        private PlugStatus(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;
        }

        public static PlugStatus Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}