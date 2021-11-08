using Effectory_Assigment.Context;
using Effectory_Assigment.Models;
using Effectory_Assigment.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Effectory_Assigment.Repository
{
    public class QuestionnaireAnswerRepository : IQuestionnaireAnswerRepository
    {
        private readonly QuestionnaireDbContext _context;

        public QuestionnaireAnswerRepository(QuestionnaireDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Creates one new answer
        /// </summary>
        /// <param name="newAnswer"></param>
        /// <returns></returns>
        public async Task<int> CreateAnswerAsync(QuestionnairePostAnswer newAnswer)
        {
            if(newAnswer == null)
            {
                throw new Exception("New answer must hava data.");
            }

            var result = await _context.postAnwers.AddAsync(newAnswer);
            _context.SaveChanges();

            return result.Entity.Id;
        }
        /// <summary>
        /// Creates several new answers
        /// </summary>
        /// <param name="newAnswers"></param>
        /// <returns></returns>
        public Task<int[]> CreateAnswersAsync(IEnumerable<QuestionnairePostAnswer> newAnswers)
        {
            if (newAnswers == null)
            {
                throw new Exception("New answers must hava data.");
            }

            var tasks = newAnswers.Select(a => CreateAnswerAsync(a));
            return Task.WhenAll(tasks);
        }

        public Task<List<QuestionnairePostAnswer>> GetAllAnswers()
        {
            return _context.postAnwers.ToListAsync();

        }
    }
}
