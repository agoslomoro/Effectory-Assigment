using Effectory_Assigment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Effectory_Assigment.Context
{
    public class JsonContext
	{
		public List<Questionnaire> Questionnaires { get; set; }

		public JsonContext(string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				throw new Exception("File Name can not be null.");
			}

			var questionnaireJson = File.ReadAllText(fileName);
			Questionnaires = JsonConvert.DeserializeObject<List<Questionnaire>>(questionnaireJson);
		}
	}
}
