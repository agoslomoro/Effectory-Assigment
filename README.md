# Effectory-Assigment

![Effectory-Assigment](https://user-images.githubusercontent.com/29106960/140667583-86435a6a-b4e8-4b3a-a608-9d43aba29e5b.jpg)

Author: Agostina Lomoro

Requirements:
* Getting one or more questions and answer options, preferably paged
* Posting one or more answers for the questions. This includes a mock userid and one of four possible departments (marketing, sales, development, reception)
* Returning a results calculation of min, max, average for each answer, calculated across the departments
* We also want you to create a test-suite for the API to check its correctness. For this you can use any approach or tool you like.

Stack:
.Net Core 3.1

Libraries:
-	Microsoft.AspNetCore.Mvc.NewtonsoftJson
-	Microsoft.EntityFrameworkCore
-	Microsoft.EntityFrameworkCore.InMemory
-	Microsoft.EntityFrameworkCore.Tools
-	Newtonsoft.Json


Testing using postman:
- https://localhost:5001/api/questionnaire/1000
- https://localhost:5001/api/questionnaireAnswer/
  - body example: [{
	"answerId": "17969123",
	"questionId": "3807638",
	"orderNumber" : 2,
	"userId": "1111",
	"department": "Sales"
	
},
{
	"answerId": "17969123",
	"questionId": "3807638",
	"orderNumber" : 4,
	"userId": "2222",
	"department": "Sales"
	
},{
	"answerId": "18166392",
	"questionId": "3851856",
	"orderNumber" : 2,
	"userId": "3333",
	"department": "Marketing"
	
},{
	"answerId": "18166393",
	"questionId": "3851856",
	"orderNumber" : 1,
	"userId": "3333",
	"department": "Development"
	
}]

- https://localhost:5001/api/statistics



Unit Testing
Tests:

GetQuestionnaire_ShouldReturnQuestionnaire
