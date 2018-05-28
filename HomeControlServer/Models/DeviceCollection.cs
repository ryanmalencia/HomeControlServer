using HomeControlServer.Interfaces;
using System.Collections.Generic;

namespace HomeControlServer.Models
{
    public class DeviceCollection : ICollection, IModel
    {
        public List<IModel> Devices;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeviceCollection()
        {
            Devices = new List<IModel>();
        }

        /// <summary>
        /// Add device to collection
        /// </summary>
        /// <param name="model">IModel to add</param>
        /// <returns>Bool with success/failure</returns>
        public bool Add(IModel model)
        {
            if (model == null)
            {
                return false;
            }
            Devices.Add(model);
            return true;
        }

        /// <summary>
        /// Get descriptive string of collection
        /// </summary>
        /// <returns>Descriptive string</returns>
        public string ToReadableString()
        {
            string output = "";
            foreach (IModel device in Devices)
            {
                output += device.ToReadableString() + "\n";
            }
            return output;
        }
    }
}