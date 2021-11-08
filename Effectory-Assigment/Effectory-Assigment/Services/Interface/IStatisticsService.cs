using Effectory_Assigment.Models;
using System.Collections.Generic;

namespace Effectory_Assigment.Services.Interface
{
    public interface IStatisticsService
	{
		List<Statistics> CalculateStatistics();
	}
}
