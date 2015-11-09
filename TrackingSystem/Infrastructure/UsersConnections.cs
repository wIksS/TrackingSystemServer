using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackingSystem.Data;

namespace TrackingSystem.Infrastructure
{
    public class UsersConnections
    {
        private static Dictionary<string, string> userConnectionsDict = new Dictionary<string, string>();

        public static void AddUser(string connectionId, string userName)
        {
            if (!userConnectionsDict.ContainsKey(userName))
            {
                userConnectionsDict.Add(userName, connectionId);
            }
        }
        public static string GetUserConnection(string userName)
        {
            if (userConnectionsDict.ContainsKey(userName))
            {
                return userConnectionsDict[userName];                
            }            

            return String.Empty;
        }
    }
}