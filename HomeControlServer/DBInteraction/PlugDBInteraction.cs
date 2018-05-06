using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeControlServer.DAL;
using HomeControlServer.Models;
using HomeControlServer.NetworkInteraction;
using System.Data.Entity.Infrastructure;

namespace HomeControlServer.DBInteraction
{
    public class PlugDBInteraction
    {
        private DataContext DB;

        public PlugDBInteraction()
        {
            DB = new DataContext();
        }

        public PlugCollection GetAll()
        {
            PlugCollection Plugs = new PlugCollection();
            foreach(Plug plug in DB.Plugs)
            {
                Plugs.AddPlug(plug);
            }
            return Plugs;
        }

        public Plug Get(int id)
        {
            return DB.Plugs.FirstOrDefault(a => a.PlugID == id);
        }

        public int GetID(string ip)
        {
            Plug temp = DB.Plugs.FirstOrDefault(a => a.IP == ip);
            if(temp == null)
            {
                return 0;
            }
            else
            {
                return temp.PlugID;
            }
        }

        public int Add(Plug plug)
        {
            DB.Plugs.Add(plug);
            try
            {
                DB.SaveChanges();
            }
            catch(DbUpdateException)
            {

            }
            return plug.PlugID;
        }

        public bool Delete(int id)
        {
            Plug temp = new Plug(id);
            DB.Plugs.Attach(temp);
            DB.Plugs.Remove(temp);
            try
            {
                DB.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return false;
            }
            return true;
        }

        public string SendData(int id, string call)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + call;
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnOneOn(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/1/on";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnOneOff(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/1/off";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnTwoOn(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/2/on";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnTwoOff(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/2/off";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnAllOn(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/on";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }

        public string TurnAllOff(int id)
        {
            string returnString = "";

            Plug plug = this.Get(id);

            if (plug != null)
            {
                string http = "http://" + plug.IP + "/off";
                returnString = NetworkClient.GetResponse(http, "GET");
            }

            return returnString;
        }
    }
}