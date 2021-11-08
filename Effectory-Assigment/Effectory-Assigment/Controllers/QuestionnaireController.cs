using Effectory_Assigment.Models;
using Effectory_Assigment.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Effectory_Assigment.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class QuestionnaireController : ControllerBase
	{
		private readonly IQuestionnaireRepository _questionnaireRepository;

		public QuestionnaireController(IQuestionnaireRepository questionnaireRepository)
		{
			_questionnaireRepository = questionnaireRepository;
		}
		// GET: api/<QuestionnaireController>
		[HttpGet("{questionnaireId}")]
		public ActionResult<Questionnaire> Get(int questionnaireId)
		{
			try
			{
				var questionnaire = _questionnaireRepository.GetQuestionnaire(questionnaireId);
				return questionnaire;
			}
			catch (Exception e)
			{
				return NotFound(e.Message);
			}
		}
	}
}
