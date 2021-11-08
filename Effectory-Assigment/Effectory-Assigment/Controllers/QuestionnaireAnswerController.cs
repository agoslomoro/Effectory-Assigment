using Effectory_Assigment.Models;
using Effectory_Assigment.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Effectory_Assigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnaireAnswerController : ControllerBase
    {
        private readonly IQuestionnaireAnswerRepository _answerRepository;

        public QuestionnaireAnswerController(IQuestionnaireAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }
        
        // POST api/<QuestionnaireAnwerController>
        [HttpPost]
        public async Task<int[]> PostAnswers([FromBody] IEnumerable<QuestionnairePostAnswer> newAnswers)
        {
            var answersIds = await _answerRepository.CreateAnswersAsync(newAnswers);
            return answersIds;
        }

    }
}
