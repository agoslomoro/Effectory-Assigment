using Effectory_Assigment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Models
{
    public class StatisticDepartment
    {
        public Department Department { get; set; }
        public int Min { get;set; }
        public int Max { get; set; }
        public int Average { get; set; }

    }
}
