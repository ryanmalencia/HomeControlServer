using System.Linq;
using HomeControlServer.DAL;
using HomeControlServer.Interfaces;
using HomeControlServer.Models;
using HomeControlServer.NetworkInteraction;
using System.Data.Entity.Infrastructure;

namespace HomeControlServer.DBInteraction
{
    public class PlugDBInteraction
    {
        private DataContext DB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlugDBInteraction()
        {
            DB = new DataContext();
        }

        /// <summary>
        /// Get all plug objects from DB
        /// </summary>
        /// <returns>Collection of plugs</returns>
        public PlugCollection GetAll()
        {
            PlugCollection Plugs = new PlugCollection();
            foreach(IModel plug in DB.Plugs)
            {
                Plugs.Add(plug);
            }
            return Plugs;
        }

        /// <summary>
        /// Get plug object from DB
        /// </summary>
        /// <param name="id">ID of plug</param>
        /// <returns>Desired plug obkect</returns>
        public Plug Get(int id)
        {
            return DB.Plugs.FirstOrDefault(a => a.PlugID == id);
        }

        /// <summary>
        /// Get ID of plug for corresponding IP from DB
        /// </summary>
        /// <param name="ip">IP of plug</param>
        /// <returns>ID of corresponding plug</returns>
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

        /// <summary>
        /// Add new plug to the DB
        /// </summary>
        /// <param name="plug">Plug object to add</param>
        /// <returns>ID in DB of added plug</returns>
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

        /// <summary>
        /// Delete plug from DB
        /// </summary>
        /// <param name="id">ID of plug to delete</param>
        /// <returns>Success/failure</returns>
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

        /// <summary>
        /// Send network request to plug
        /// </summary>
        /// <param name="id">ID of plug</param>
        /// <param name="call">Network call</param>
        /// <returns>Data returned from plug</returns>
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
    }
}