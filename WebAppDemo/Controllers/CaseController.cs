using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Interfaces.Services;
using WebAppDemo.Properties.Dtos;

namespace WebAppDemo.Controllers
{
    public class CaseController : Controller
    {
        private readonly ICaseService _caseService;
        public CaseController(ICaseService caseService)
        {
            _caseService = caseService;
        }
        public IActionResult Index()
        {
            var cases = _caseService.GetCases();
            return View(cases);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCaseRequestModel model)
        {
            _caseService.AddCase(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var caase = _caseService.GetCase(id);
            return View(caase);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var caase = _caseService.GetCase(id);
            if (caase == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(int id, UpdateCaseRequestModel model)
        {
            _caseService.UpdateCase(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var caase = _caseService.GetCase(id);
            if (caase == null)
            {
                return NotFound();
            }
            return View(caase);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _caseService.DeleteCase(id);
            return RedirectToAction("Index");
        }

    }
}
