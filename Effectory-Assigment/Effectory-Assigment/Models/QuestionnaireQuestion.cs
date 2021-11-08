using Newtonsoft.Json;
using System.Collections.Generic;

namespace Effectory_Assigment.Models
{
    public partial class QuestionnaireQuestion
	{
		[JsonProperty("questionId")]
		public int QuestionId { get; set; }

		[JsonProperty("subjectId")]
		public int SubjectId { get; set; }

		[JsonProperty("answerCategoryType")]
		public int AnswerCategoryType { get; set; }

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
