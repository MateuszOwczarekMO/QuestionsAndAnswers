namespace QuestionsAndAnswers.Models
{
    public class QnA
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string ImgUrl { get; set; }
    }
}
