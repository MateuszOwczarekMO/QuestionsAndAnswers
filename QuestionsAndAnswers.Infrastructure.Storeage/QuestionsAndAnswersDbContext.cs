using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswers.Models;
namespace QuestionsAndAnswers.Infrastructure.Storeage
{
    public class QuestionsAndAnswersDbContext : DbContext
    {
        public QuestionsAndAnswersDbContext(DbContextOptions<QuestionsAndAnswersDbContext> options)
            : base(options)
        {

        }

        public DbSet<QnA> QnAs { get; set; }
    }
}
