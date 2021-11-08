using Effectory_Assigment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Effectory_Assigment.Repository.Interface
{
    public interface IQuestionnaireAnswerRepository
	{
		Task<int> CreateAnswerAsync(QuestionnairePostAnswer postAnswer);
		Task<int[]> CreateAnswersAsync(IEnumerable<QuestionnairePostAnswer> postAnswer);
		Task<List<QuestionnairePostAnswer>> GetAllAnswers();
	}
}
