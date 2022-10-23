using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Web.Services
{
    public class QnAService : IQnAService
    {
        private readonly HttpClient _httpClient;
        private readonly static string _baseUrl = "api/qna";

        public QnAService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async ValueTask<IEnumerable<QnA>> GetAllQnAs()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<QnA>>(_baseUrl);
        }

        public async Task RegisterQnA(QnA qnA)
        {
            await _httpClient.PostAsJsonAsync(_baseUrl, qnA);
        }

        public Task RemoveQna(QnA qna)
        {
            throw new NotImplementedException();
        }
    }
}
