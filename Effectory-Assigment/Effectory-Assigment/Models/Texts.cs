using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Models
{
    public partial class Texts
    {
        [JsonProperty("nl-NL")]
        public string NlNl { get; set; }

        [JsonProperty("en-US")]
        public string EnUs { get; set; }
    }
}
