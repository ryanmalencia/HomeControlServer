using HomeControlServer.Interfaces;

namespace HomeControlServer.Models
{
    public class Device : IModel
    {
        public string ToReadableString()
        {
            return "Device";
        }
    }
}