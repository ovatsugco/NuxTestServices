using Nuxiba.Services.Entity;
using Nuxiba.Services.WsDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Nuxiba.Services.Business
{
    public static class ProcessUser
    {
        public static List<User> ProcessGetUser(string url)
        {
            var WsDataAcces = new GetDataService();
            return WsDataAcces.GetUsers(url);
        }
        public static List<Post> ProcessGetUserPost(string url, string idUser)
        {
            var WsDataAcces = new GetDataService();
            return WsDataAcces.GetUserPosts(url, idUser);
        }
        public static List<Task> ProcessGetUserTasks(string url, string idUser)
        {
            var WsDataAcces = new GetDataService();
            var res = WsDataAcces.GetUserTasks(url, idUser);
            return res.OrderByDescending(predicate => predicate.Id).ToList();
        }
        public static string ProcessSaveData(string url, Nuxiba.Services.Entity.Task data)
        {
            var WsDataAcces = new GetDataService();
            return WsDataAcces.GetSaveData(url, data);
            
        }
        
    }
}
