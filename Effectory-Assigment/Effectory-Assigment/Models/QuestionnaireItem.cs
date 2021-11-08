using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Models
{
    public partial class QuestionnaireItem
    {
        [JsonProperty("subjectId")]
        public int SubjectId { get; set; }

        [JsonProperty("orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty("texts")]
        public Texts Texts { get; set; }

        [JsonProperty("itemType")]
        public int ItemType { get; set; }

        [JsonProperty("questionnaireItems")]
        public List<QuestionnaireQuestion> QuestionnaireItems { get; set; }
    }
}
