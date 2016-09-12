using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gcm.Samples.MessageBoard.WebApp.Services;

namespace Gcm.Samples.MessageBoard.WebApp.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageService _messageService = new InMemoryMessageService();

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            _messageService.PostMessage(message);

            return this.RedirectToAction("Index", "Home");
        }
    }
}