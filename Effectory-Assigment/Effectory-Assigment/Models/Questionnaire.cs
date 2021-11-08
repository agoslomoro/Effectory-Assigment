using Newtonsoft.Json;
using System.Collections.Generic;

namespace Effectory_Assigment.Models
{
    public partial class Questionnaire
	{
		[JsonProperty("questionnaireId")]
		public int QuestionnaireId { get; set; }

		[JsonProperty("questionnaireItems")]
		public List<QuestionnaireItem> QuestionnaireItems { get; set; }
	}
}
