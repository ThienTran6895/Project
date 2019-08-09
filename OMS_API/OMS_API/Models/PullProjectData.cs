using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS_API.Models
{
    public class PullProjectData
    {
        public int sourceID { get; set; }
        public int projectID { get; set; }
        public DateTime datefrom { get; set; }
        public DateTime dateend { get; set; }
    }
}
