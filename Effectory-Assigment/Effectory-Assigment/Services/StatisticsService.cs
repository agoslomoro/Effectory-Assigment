using Effectory_Assigment.Context;
using Effectory_Assigment.Models;
using Effectory_Assigment.Models.Enums;
using Effectory_Assigment.Repository;
using Effectory_Assigment.Repository.Interface;
using Effectory_Assigment.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IQuestionnaireAnswerRepository _questionnaireAnswerRepository;

        public StatisticsService(IQuestionnaireAnswerRepository questionnaireAnswerRepository)
        {
            _questionnaireAnswerRepository = questionnaireAnswerRepository;
        }

        //for taking the average I took the orderNumber as reference, I guess that in other case each entity would have a score or puntuation to use for statistics.
        public List<Statistics> CalculateStatistics()
        {
            var allAnswers = _questionnaireAnswerRepository.GetAllAnswers();
            var statisticsList = new List<Statistics>();

            Dictionary<int, List<QuestionnairePostAnswer>> answersByQuestion = new Dictionary<int, List<QuestionnairePostAnswer>>();
            answersByQuestion = allAnswers.Result.GroupBy(q => q.QuestionId).ToDictionary(x => x.Key, x => x.ToList());

            foreach (KeyValuePair<int, List<QuestionnairePostAnswer>> keyValuePair in answersByQuestion)
            {
                Statistics statistics = new Statistics();

                statistics.QuestionId = keyValuePair.Key;

                var statisticDeparmentList = new List<StatisticDepartment>();

                Dictionary<Department, List<QuestionnairePostAnswer>> answersByDeparment = keyValuePair.Value.GroupBy(d => d.Department).ToDictionary(x => x.Key, x => x.ToList());

                foreach (KeyValuePair<Department, List<QuestionnairePostAnswer>> keyValueDepartment in answersByDeparment)
                {
                    StatisticDepartment statisticDeparment = new StatisticDepartment();

                    statisticDeparment.Department = keyValueDepartment.Key;
                    int min = 100;
                    int max = 0;
                    int average = 0;
                    int total = 0;

                    for (int i = 0; i < keyValueDepartment.Value.Count; i++)
                    {
                        if (min > keyValueDepartment.Value[i].OrderNumber)
                        {
                            min = keyValueDepartment.Value[i].OrderNumber;
                        }
                        if (max < keyValueDepartment.Value[i].OrderNumber)
                        {
                            max = keyValueDepartment.Value[i].OrderNumber;
                        }
                        total = +keyValueDepartment.Value[i].OrderNumber;
                    }

                    average = total / keyValueDepartment.Value.Count;

                    statisticDeparment.Min = min;
                    statisticDeparment.Max = max;
                    statisticDeparment.Average = average;

                    statisticDeparmentList.Add(statisticDeparment);
                }
                statistics.statisticDepartments = statisticDeparmentList;
                statisticsList.Add(statistics);
            }
            return statisticsList;
        }
    }
}
