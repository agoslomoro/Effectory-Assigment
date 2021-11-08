using System.Collections.Generic;

namespace Effectory_Assigment.Models
{
    public partial class Statistics
	{
		public int QuestionId { get; set; }
		public List<StatisticDepartment> statisticDepartments { get; set; }
	}
}
