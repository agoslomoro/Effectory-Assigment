using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
