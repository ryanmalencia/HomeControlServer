using HomeControlServer.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeControlServer.Models
{
    public class Switch : IModel
    {
        public int SwitchID { get; set; }
        public string Name { get; set; }
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string IP { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Switch()
        {

        }

        /// <summary>
        /// Constructor with ID parameter
        /// </summary>
        /// <param name="id">ID of switch</param>
        public Switch(int id)
        {
            SwitchID = id;
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