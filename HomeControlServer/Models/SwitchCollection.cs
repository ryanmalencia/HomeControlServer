using HomeControlServer.Interfaces;
using System.Collections.Generic;

namespace HomeControlServer.Models
{
    public class SwitchCollection : ICollection, IModel
    {
        public List<IModel> Switches;

        /// <summary>
        /// Default constructor
        /// </summary>
        public SwitchCollection()
        {
            Switches = new List<IModel>();
        }

        /// <summary>
        /// Add switch to collection
        /// </summary>
        /// <param name="model">IModel to add (as switch)</param>
        /// <returns>Bool with success/failure</returns>
        public bool Add(IModel model)
        {
            if (model == null)
            {
                return false;
            }
            Switches.Add((Switch)model);
            return true;
        }

        /// <summary>
        /// Get descriptive string of collection
        /// </summary>
        /// <returns>Descriptive string</returns>
        public string ToReadableString()
        {
            string output = "";
            foreach (Switch theSwitch in Switches)
            {
                output += theSwitch.ToReadableString() + "\n";
            }
            return output;
        }
    }
}