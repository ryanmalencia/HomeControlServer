using System.Collections.Generic;

namespace HomeControlServer.Models
{
    public class PlugCollection
    {
        public List<Plug> Plugs;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlugCollection()
        {
            Plugs = new List<Plug>();
        }

        /// <summary>
        /// Add plug to collection
        /// </summary>
        /// <param name="plug">Plug to add</param>
        /// <returns>Bool with success/failure</returns>
        public bool AddPlug(Plug plug)
        {
            if(plug == null)
            {
                return false;
            }
            Plugs.Add(plug);
            return true;
        }
    }
}