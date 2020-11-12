using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPLabs.Web.Models;

namespace ASPLabs.Web.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            //var viewModel = new CompanyAddedViewModel
            //{
            //    NumberOfCharsInName = company.Name.Length,
            //    NumberOfChartsInDescription = company.Description.Length,
            //    IsHidden = !company.IsVisible
            //};

            //return View("CompanyAdded", viewModel);

            return RedirectToAction("CompanyAdded");
        }

        [HttpGet]
        public IActionResult CompanyAdded()
        {
            return View();
        }
    }
}