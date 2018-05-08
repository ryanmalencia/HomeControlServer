using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace HomeControlServer.SignalR
{
    [HubName("PlugStatusHub")]
    public class PlugStatusHub : Hub
    {
        private readonly PlugStatus _plugStatus;

        public PlugStatusHub() : this(PlugStatus.Instance)
        {

        }

        public PlugStatusHub(PlugStatus plugStatus)
        {
            _plugStatus = plugStatus;
        }
    }
} 