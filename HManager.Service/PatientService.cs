using HManager.Dal.Entity;
using HManager.Dal.Repository;
using HManager.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HManager.Service
{
    public class PatientService
    {
        private IRepository<Patient> _repository { get; set; }

        public PatientService(IRepository<Patient> repo)
        {
            _repository = repo;
        }

        public IList<PatientIndexListItem> GetAllPatientForIndex()
        {
            return _repository.GetAll().Select(x => new PatientIndexListItem
            {
                ID = x.ID,
                Firstname = x.Firstname,
                Lastname = x.Lastname,
                Phone = x.Phone
            }).ToList();
        }
    }
    
}
