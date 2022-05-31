using HManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HManager.Service;
using HManager.Service.DTO;
using HManager.Web.ViewModels;

namespace HManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly PatientService _patientService;

        public HomeController(ILogger<HomeController> logger, PatientService patientService)
        {
            _logger = logger;
            _patientService = patientService;
        }

        public IActionResult Index()
        {
            IList<PatientIndexListItem> patients = _patientService.GetAllPatientForIndex();

            var model = new HomeIndexViewModel
            {
                Patients = patients
            };

            return View(model);
        }

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
