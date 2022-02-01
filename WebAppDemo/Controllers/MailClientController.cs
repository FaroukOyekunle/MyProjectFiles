using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Controllers
{
    public class MailClientController : Controller
    {
        private readonly IMailClientService _mailclientService;
         public MailClientController( IMailClientService mailclientService)
         {
            _mailclientService = mailclientService;
         }

        public IActionResult Index()
        {
            var mailclients = _mailclientService.GetMailClients();
            return View(mailclients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateMailClientRequestModel model)
        {
            _mailclientService.AddMailClient(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var mailclient = _mailclientService.GetMailClient(id);
            return View(mailclient);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var mailclient = _mailclientService.GetMailClient(id);
            if (mailclient == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateMailClientRequestModel model)
        {
            _mailclientService.UpdateMailClient(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var mailclient = _mailclientService.GetMailClient(id);
            if (mailclient == null)
            {
                return NotFound();
            }
            return View(mailclient);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _mailclientService.DeleteMailClient(id);
            return RedirectToAction("Index");
        }
    }
}