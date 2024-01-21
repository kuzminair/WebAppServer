

using Microsoft.EntityFrameworkCore;

namespace WebAppServer.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Validity { get; set; }
        public int ServerModelId { get; set; }
        public int OsId { get; set; }


        public Server(int id, string name, int validity, int serverModelId, int osId)
        {
            Id = id;
            Name = name;
            Validity = validity;
            ServerModelId = serverModelId;
            OsId = osId;
        }
        public static List<Server> serverList = new List<Server> { };
        //public static List<Server> serverListUniq = new List<Server> { };
    }
}
