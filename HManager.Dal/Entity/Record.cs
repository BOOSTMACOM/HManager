using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HManager.Dal.Entity
{
    public class Record : BaseEntity
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Patient Patient { get; set; }
        public Service Service { get; set; }

    }
}
