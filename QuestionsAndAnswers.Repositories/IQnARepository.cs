using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Repositories
{
    public interface IQnARepository
    {
        Task RegisterQnA(QnA qnA);
        Task RemoveQnA(QnA qnA);
        ValueTask<IEnumerable<QnA>> GetAllQnAs();
    }
}
