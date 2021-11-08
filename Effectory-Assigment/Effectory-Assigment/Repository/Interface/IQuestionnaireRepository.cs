using Effectory_Assigment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Repository.Interface
{
    public interface IQuestionnaireRepository
    {
        Questionnaire GetQuestionnaire(int id);
    }
}
