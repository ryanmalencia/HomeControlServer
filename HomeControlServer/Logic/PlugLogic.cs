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

        public int GetID(string ip)
        {
            return PlugDB.GetID(ip);
        }

        public int Add(Plug plug)
        {
            return PlugDB.Add(plug);
        }

        public bool Delete(int id)
        {
            return PlugDB.Delete(id);
        }

        public string SendData(int id, string call)
        {
            return PlugDB.SendData(id, call);
        }

        public string TurnOneOn(int id)
        {
            return PlugDB.TurnOneOn(id);
        }

        public string TurnOneOff(int id)
        {
            return PlugDB.TurnOneOff(id);
        }

        public string TurnTwoOn(int id)
        {
            return PlugDB.TurnTwoOn(id);
        }

        public string TurnTwoOff(int id)
        {
            return PlugDB.TurnTwoOff(id);
        }

        public string TurnAllOn(int id)
        {
            return PlugDB.TurnAllOn(id);
        }

        public string TurnAllOff(int id)
        {
            return PlugDB.TurnAllOff(id);
        }
    }
}