using Effectory_Assigment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Models
{
    public partial class QuestionnairePostAnswer
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int OrderNumber { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public Department Department { get; set; }
    }
}
