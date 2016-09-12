using System;
using System.Linq;
using System.Web.Mvc;
using Gcm.Samples.MessageBoard.WebApp.Models;
using Gcm.Samples.MessageBoard.WebApp.Services;

namespace Gcm.Samples.MessageBoard.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService = new InMemoryMessageService();

        // GET: Home
        public ActionResult Index()
        {
            var message = _messageService.GetMessages().ToArray();

            var viewModel = new HomeIndexViewModel()
            {
                Messages = message
            };

            return View(viewModel);
        }
    }
}