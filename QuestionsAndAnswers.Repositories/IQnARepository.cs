using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Repositories
{
    public interface IQnARepository
    {
        Task CreateQnA(QnA qnA);
        Task RemoveQnA(QnA qnA);
        ValueTask<IEnumerable<QnA>> GetAllQnAs(QnA qnA);
    }
}
