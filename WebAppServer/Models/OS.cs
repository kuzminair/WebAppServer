

namespace WebAppServer.Models
{
    public class OS
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OS(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public static List<OS> osList = new List<OS> { };
        public static List<OS> osListUniq = new List<OS> { };
    }
}
