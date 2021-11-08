using Effectory_Assigment.Models;
using Microsoft.EntityFrameworkCore;

namespace Effectory_Assigment.Context
{
    public class QuestionnaireDbContext : DbContext
	{
		public DbSet<QuestionnairePostAnswer> postAnwers { get; set; }

		public QuestionnaireDbContext(DbContextOptions<QuestionnaireDbContext> options) : base(options)
		{

		}
	}
}
