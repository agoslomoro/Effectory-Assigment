using Effectory_Assigment.Context;
using Effectory_Assigment.Models;
using Effectory_Assigment.Repository.Interface;
using System;
using System.Linq;

namespace Effectory_Assigment.Repository
{
    public class QuestionnaireRepository : IQuestionnaireRepository
	{
		private readonly JsonContext _context;

		public QuestionnaireRepository(JsonContext jsonContext)
		{
			_context = jsonContext;
		}
		public Questionnaire GetQuestionnaire(int questionnaireId)
		{
			var result = _context.Questionnaires.FirstOrDefault(x => x.QuestionnaireId == questionnaireId);
			if (result == null)
			{
				throw new Exception("Questionnaire NOT found.");
			}

			return result;
		}
	}
}
