using System.Security.Cryptography;
using WebAppServer.Models;

namespace WebAppServer.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<OS> OSEnumer { get; set; } = new List<OS>();
        public IEnumerable<Server> ServerEnumer { get; set; } = new List<Server>();
        public IEnumerable<ServerModel> ServerModelEnumer { get; set; } = new List<ServerModel>();
    }
}
