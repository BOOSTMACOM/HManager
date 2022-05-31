using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HManager.Service.DTO;

namespace HManager.Web.ViewModels
{
    public class HomeIndexViewModel
    {
        public IList<PatientIndexListItem> Patients { get; set; }

        public HomeIndexViewModel()
        {
            Patients = new List<PatientIndexListItem>();
        }

    }
}
