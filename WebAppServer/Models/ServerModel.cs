
namespace WebAppServer.Models
{
    public class ServerModel
    {
        public int Id { get; set; }
        public string NameCompany { get; set; }
        public int MadeYear { get; set; }
        public int Speed { get; set; } //5400, 7200 и 10 000 об/мин
        public string TypeServer { get; set; }


        public ServerModel(int id, string nameCompany, int madeYear, int speed, string typeServer)
        {
            Id = id;
            NameCompany = nameCompany;
            MadeYear = madeYear;
            Speed = speed;
            TypeServer = typeServer;
        }

        public static List<ServerModel> serverModelList = new List<ServerModel> { };
        //public static List<ServerModel> serverModelListUniq = new List<ServerModel> { };
    }
}
