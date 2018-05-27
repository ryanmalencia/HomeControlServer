using HomeControlServer.Interfaces;
using System.Collections.Generic;

namespace HomeControlServer.Models
{
    public class PlugCollection : ICollection, IModel
    {
        public List<IModel> Plugs;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlugCollection()
        {
            Plugs = new List<IModel>();
        }

        /// <summary>
        /// Add plug to collection
        /// </summary>
        /// <param name="model">IModel to add (as plug)</param>
        /// <returns>Bool with success/failure</returns>
        public bool Add(IModel model)
        {
            if(model == null)
            {
                return false;
            }
            Plugs.Add((Plug)model);
            return true;
        }

        /// <summary>
        /// Get descriptive string of collection
        /// </summary>
        /// <returns>Descriptive string</returns>
        public string ToReadableString()
        {
            string output = "";
            foreach(Plug plug in Plugs)
            {
                output += plug.ToReadableString() + "\n";
            }
            return output;
        }
    }
}