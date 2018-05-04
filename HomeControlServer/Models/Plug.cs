using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeControlServer.Models
{
    public class Plug
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

        public Plug(int id)
        {
            PlugID = id;
        }
    }
}