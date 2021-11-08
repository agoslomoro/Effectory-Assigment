using Newtonsoft.Json;
using System.Collections.Generic;

namespace Effectory_Assigment.Models
{
    public partial class QuestionnaireAnswer
	{
		[JsonProperty("answerId")]
		public int? AnswerId { get; set; }

		[JsonProperty("questionId")]
		public int QuestionId { get; set; }

		[JsonProperty("answerType")]
		public int AnswerType { get; set; }

		[JsonProperty("orderNumber")]
		public int OrderNumber { get; set; }

		[JsonProperty("texts")]
		public Texts Texts { get; set; }

		[JsonProperty("itemType")]
		public int ItemType { get; set; }

		[JsonProperty("questionnaireItems")]
		public List<QuestionnaireAnswer> QuestionnaireItems { get; set; }
	}
}
