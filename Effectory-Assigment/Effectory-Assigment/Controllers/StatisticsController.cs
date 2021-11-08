using Effectory_Assigment.Models;
using Effectory_Assigment.Repository.Interface;
using Effectory_Assigment.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        // GET: api/<StatisticsController>
        [HttpGet]
        public IEnumerable<Statistics> Get()
        {
            try
            {
                //var statistics = 
                return _statisticsService.CalculateStatistics();
            }
            catch (Exception e)
            {
                throw new Exception("Error.");
            }
        }
    }
}
