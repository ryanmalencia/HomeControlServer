using HomeControlServer.Models;
using HomeControlServer.DBInteraction;

namespace HomeControlServer.Logic
{
    public class PlugLogic
    {
        private PlugDBInteraction PlugDB = new PlugDBInteraction();

        /// <summary>
        /// Get all plugs
        /// </summary>
        /// <returns>Collection of plugs</returns>
        public PlugCollection GetAll()
        {
            return PlugDB.GetAll();
        }

        /// <summary>
        /// Get plug by ID
        /// </summary>
        /// <param name="id">ID of plug</param>
        /// <returns>Corresponding plug object</returns>
        public Plug Get(int id)
        {
            return PlugDB.Get(id);
        }

        /// <summary>
        /// Get ID from IP
        /// </summary>
        /// <param name="ip">IP of plugs</param>
        /// <returns>ID of corresponding plug</returns>
        public int GetID(string ip)
        {
            return PlugDB.GetID(ip);
        }

        /// <summary>
        /// Add a new plug
        /// </summary>
        /// <param name="plug">Plug object to add</param>
        /// <returns>ID of added plug</returns>
        public int Add(Plug plug)
        {
            return PlugDB.Add(plug);
        }

        /// <summary>
        /// Delete a plug
        /// </summary>
        /// <param name="id">ID of plug to delete</param>
        /// <returns>Success/failure</returns>
        public bool Delete(int id)
        {
            return PlugDB.Delete(id);
        }

        /// <summary>
        /// Send a network call to plug
        /// </summary>
        /// <param name="id">ID of desired plug</param>
        /// <param name="call">Network call</param>
        /// <returns>Data returned from plug</returns>
        public string SendData(int id, string call)
        {
            return PlugDB.SendData(id, call);
        }
    }
}