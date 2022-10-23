using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Web.Services
{
    public interface IQnAService
    {
        ValueTask<IEnumerable<QnA>> GetAllQnAs();
        Task RegisterQnA(QnA qnA);
        Task RemoveQna(QnA qna);
    }
}
