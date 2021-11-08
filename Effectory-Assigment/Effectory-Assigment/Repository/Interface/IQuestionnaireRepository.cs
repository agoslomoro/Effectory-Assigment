using Effectory_Assigment.Models;

namespace Effectory_Assigment.Repository.Interface
{
    public interface IQuestionnaireRepository
	{
		Questionnaire GetQuestionnaire(int id);
	}
}
