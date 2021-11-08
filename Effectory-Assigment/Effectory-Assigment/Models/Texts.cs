using Newtonsoft.Json;

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
