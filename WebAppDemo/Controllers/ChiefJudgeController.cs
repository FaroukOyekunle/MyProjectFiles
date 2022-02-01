using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Controllers
{
    public class ChiefJudgeController : Controller
    {

        private readonly IChiefJudgeService _chiefJudgeService;
        private readonly IMailClientService _mailClientService;
        private readonly ICaseService _caseService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ChiefJudgeController(IChiefJudgeService chiefJudgeService, IMailClientService mailClientService, ICaseService caseService, IWebHostEnvironment webHostEnvironment)
        {
            _chiefJudgeService = chiefJudgeService;
            _mailClientService = mailClientService;
            _caseService = caseService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var chiefJudges = _chiefJudgeService.GetChiefJudges();
            return View(chiefJudges);
        }

        public IActionResult Create()
        {
            var mailClients = _mailClientService.GetMailClients();
            ViewData["MailClients"] = new SelectList(mailClients, "Id", "MailClientFirstName");

            var cases = _caseService.GetCases();
            ViewData["Cases"] = new SelectList(cases, "Id", "CaseName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateChiefJudgeRequestModel model, IFormFile chiefJudgePhoto)
        {
            string chiefJudgePhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "chiefJudgePhotos");
            Directory.CreateDirectory(chiefJudgePhotoPath);
            string contentType = chiefJudgePhoto.ContentType.Split('/')[1];
            string chiefJudgeImage = $"STD{Guid.NewGuid()}.{contentType}";
            string fullPath = Path.Combine(chiefJudgePhotoPath, chiefJudgeImage);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                chiefJudgePhoto.CopyTo(fileStream);
            }
            model.ChiefJudgePhoto = chiefJudgeImage;

            _chiefJudgeService.AddChiefJudge(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var chiefJudge = _chiefJudgeService.GetChiefJudge(id);
            return View(chiefJudge);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var chiefJudge = _chiefJudgeService.GetChiefJudge(id);
            if (chiefJudge == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateChiefJudgeRequestModel model)
        {
            _chiefJudgeService.UpdateChiefJudge(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var chiefJudge = _chiefJudgeService.GetChiefJudge(id);
            if (chiefJudge == null)
            {
                return NotFound();
            }
            return View(chiefJudge);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _chiefJudgeService.DeleteChiefJudge(id);
            return RedirectToAction("Index");
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequestModel model)
        {
            var chiefJudge = _chiefJudgeService.Login(model);
            if (chiefJudge != null)
            {
                HttpContext.Session.SetString("Id", chiefJudge.Id.ToString());
                HttpContext.Session.SetString("email", chiefJudge.Email);
                HttpContext.Session.SetString("firstName", chiefJudge.FirstName);
                HttpContext.Session.SetString("lastName", chiefJudge.LastName);
                HttpContext.Session.SetString("lastName", chiefJudge.OtherName);
                HttpContext.Session.SetString("address", chiefJudge.Address);
                HttpContext.Session.SetString("phoneNumber", chiefJudge.PhoneNumber);
                HttpContext.Session.SetString("gender", chiefJudge.Gender);
                HttpContext.Session.SetString("photo", chiefJudge.ChiefJudgePhoto);
                var i = 1;
                foreach (var caase in chiefJudge.Cases)
                {
                    HttpContext.Session.SetString($"caase{i}", caase.CaseName);
                    i++;
                }
                HttpContext.Session.SetString("numberOfCases", chiefJudge.Cases.Count.ToString());
                HttpContext.Session.SetString("role", "ChiefJudge");
                HttpContext.Session.CommitAsync();

                return RedirectToAction("Profile");
            }

            else
            {
                ViewBag.error = "Invalid username or password";
                return View();
            }

        }

    }

}