using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppServer.Models;
using Microsoft.EntityFrameworkCore;
using WebAppServer.ViewModels;

namespace WebAppServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            db = context;
        }
        AppDbContext db;


        public void LoadList()
        {
            using (db)
            {
                Server.serverList = db.Servers.ToList();
                //Server.serverListUniq = db.Servers.ToList().Distinct().ToList();
                ServerModel.serverModelList = db.ServersModels.ToList();
                //ServerModel.serverModelListUniq = db.ServersModels.ToList().Distinct().ToList();
                OS.osList = db.Oss.ToList();
                OS.osListUniq = db.Oss.ToList().Distinct().ToList();
            }
        }
        public IActionResult Index()
        {
            LoadList();
            return View();
        }

        //public IActionResult Index(int? serverId)
        //{
        //    List<Server> serversSelect = Server.serverList.Select(c => new Server(c.Id, c.Name, c.Validity, c.ServerModelId, c.OsId)).ToList();
        //    IndexViewModel viewModel = new() { };

        //    if (serverId != null)
        //    {
        //        viewModel.ServerEnumer = Server.serverList.Where(p => p.Id == serverId);
        //    }
        //    return View(viewModel);
        //}






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
