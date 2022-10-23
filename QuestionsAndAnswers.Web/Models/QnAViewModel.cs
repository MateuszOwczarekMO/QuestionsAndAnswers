using QuestionsAndAnswers.Models;

namespace QuestionsAndAnswers.Web.Models
{
    public class QnAViewModel
    {
        public QnA Data { get; set; }
        public bool Show { get; set; }

        public QnAViewModel(QnA qnA)
        {
            Data = qnA;
            Show = false;
        }
    }
}
