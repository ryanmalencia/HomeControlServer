using HomeControlServer.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeControlServer.Models
{
    public class Plug : IModel
    {
        public int PlugID { get; set; }
        public string Name { get; set; }
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string IP { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Plug()
        {

        }

        /// <summary>
        /// Constructor with ID
        /// </summary>
        /// <param name="id">ID of plug</param>
        public Plug(int id)
        {
            PlugID = id;
        }

        /// <summary>
        /// Get descriptive string
        /// </summary>
        /// <returns>Descriptive string</returns>
        public string ToReadableString()
        {
            return Name + " at IP: " + IP;
        }
    }
}