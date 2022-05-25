using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HManager.Service.DTO
{
    public class PatientRecordDetailsDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ServiceName { get; set; }

    }
}
