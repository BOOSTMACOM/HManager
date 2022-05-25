using System;
using HManager.Dal;
using HManager.Dal.Repository;
using HManager.Dal.Entity;
using HManager.Service.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HManager.Service
{
    public class RecordService
    {
        private IRepository<Record> _repository { get; set; }

        public RecordService(IRepository<Record> repository)
        {
            _repository = repository;
        }

        public PatientRecordDetailsDTO GetRecordDetailsForPatient(int PatientID)
        {
            IEnumerable<Record> records = _repository.GetAll();
            PatientRecordDetailsDTO record = records.Where(x => x.Patient.ID == PatientID).Select(x => new PatientRecordDetailsDTO
            {
                Firstname = x.Patient.Firstname,
                Lastname = x.Patient.Lastname,
                BeginDate = x.BeginDate,
                EndDate = x.EndDate,
                ServiceName = x.Service.Name
            }).FirstOrDefault();

            return record;
        }


    }
}
