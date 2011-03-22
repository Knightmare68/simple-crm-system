using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace Client
{

    class ServerInfo
    {
        public string ServerName { get; set; }
        public string ServerAddress{ get; set; }
        public int Port { get; set; }
    }
    class Utility
    {
        public static IList<ServerInfo> GetServerList()
        {
            List<ServerInfo> serverlist = new List<ServerInfo>();

            ServerInfo server = new ServerInfo();
            server.ServerName = ConfigurationManager.AppSettings["Server"].ToString();
            server.ServerAddress = ConfigurationManager.AppSettings["Server"].ToString();
            server.Port = Convert.ToInt32(ConfigurationManager.AppSettings["ServerPort"].ToString());
            serverlist.Add(server);
            return serverlist;
        }
    }
}
