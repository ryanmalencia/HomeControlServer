using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeControlServer.Models;
using HomeControlServer.DBInteraction;

namespace HomeControlServer.Logic
{
    public class PlugLogic
    {
        private PlugDBInteraction PlugDB = new PlugDBInteraction();

        public PlugCollection GetAll()
        {
            return PlugDB.GetAll();
        }

        public Plug Get(int id)
        {
            return PlugDB.Get(id);
        }

        public int Add(Plug plug)
        {
            return PlugDB.Add(plug);
        }

        public bool Delete(int id)
        {
            return PlugDB.Delete(id);
        }
    }
}