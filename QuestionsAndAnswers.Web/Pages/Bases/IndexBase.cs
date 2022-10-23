using Microsoft.AspNetCore.Components;
using QuestionsAndAnswers.Models;
using QuestionsAndAnswers.Web.Models;
using QuestionsAndAnswers.Web.Services;

namespace QuestionsAndAnswers.Web.Pages.Bases
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        private IQnAService _qnAService { get; set; }

        public List<QnAViewModel> QnAs { get; set; } = new List<QnAViewModel>();

        public bool Loading { get; set; } = true;

        public bool ShowAddForm { get; set; } = false;
        public string Question { get; set; } = "";
        public string Answer { get; set; } = "";
        public string ImgUrl { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            await LoadQnAs();
        }

        public async Task LoadQnAs()
        {
            Loading = true;
            QnAs = new List<QnAViewModel>();
            var r = await _qnAService.GetAllQnAs();

            foreach(var qn in r)
                QnAs.Add(new QnAViewModel(qn));

            Loading = false;
        }

        public void ToggleAddQnA()
        {
            if (ShowAddForm)
            {
                Question = "";
                Answer = "";
                ImgUrl = "";
                ShowAddForm = false;
            }
            else
            {
                ShowAddForm = true;
            }
        }

        public void ToggleQnA(Guid id)
        {
            var q = QnAs.FirstOrDefault(q => q.Data.Id == id);
            q.Show = !q.Show;   
        }
        public async Task AddQnA()
        {
            var req = new QnA
            {
                Question = Question,
                Answer = Answer,
                ImgUrl = ImgUrl,
            };

            await _qnAService.RegisterQnA(req);
            ToggleAddQnA();
            await LoadQnAs();
        }
    }
}
