using Microsoft.AspNetCore.Mvc;
using QuestionsAndAnswers.Models;
using QuestionsAndAnswers.Repositories;

namespace QuestionsAndAnswers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QnAController : ControllerBase
    {
        private readonly IQnARepository _repository;

        public QnAController(IQnARepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QnA>>> GetAllQnAs()
        {
            var results = await _repository.GetAllQnAs();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult> RegisterQnA(QnA qnA)
        {
            if (!string.IsNullOrEmpty(qnA.ImgUrl))
            {
                qnA.ImgUrl = $"/img/{qnA.ImgUrl}";
            }
            await _repository.RegisterQnA(qnA);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveQnA(QnA qnA)
        {
            await _repository.RemoveQnA(qnA);
            return NoContent();
        }
    }
}
