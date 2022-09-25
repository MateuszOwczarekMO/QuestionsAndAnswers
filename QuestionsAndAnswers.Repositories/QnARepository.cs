using Microsoft.EntityFrameworkCore;
using QuestionsAndAnswers.Infrastructure.Storeage;
using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Repositories
{
    public class QnARepository : IQnARepository
    {
        private readonly QuestionsAndAnswersDbContext _context;

        public QnARepository(QuestionsAndAnswersDbContext context)
        {
            _context = context;
        }

        public async Task RegisterQnA(QnA qnA)
        {
            await _context.AddAsync(qnA);
            await _context.SaveChangesAsync();
        }

        public async ValueTask<IEnumerable<QnA>> GetAllQnAs()
        {
            return await _context.QnAs.ToListAsync();
        }

        public async Task RemoveQnA(QnA qnA)
        {
            _context.Remove(qnA);
            await _context.SaveChangesAsync();
        }
    }
}
