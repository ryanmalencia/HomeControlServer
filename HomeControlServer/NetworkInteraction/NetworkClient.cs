using System;
using System.Net;

namespace HomeControlServer.NetworkInteraction
{
    public class NetworkClient
    {
        public static string GetResponse(string http, string method)
        {
            string returnString = "";

            using (var request = new WebClient())
            {
                try
                {
                    returnString = request.DownloadString(http);
                }
                catch(Exception)
                {
                    returnString = http;
                }
            }
            return returnString;
        }
    }
}