using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;

namespace WodCatClone.Web.Pages.MorePage
{
    public partial class CallBackPage
    {
        [Inject] public ICallBackService CallBackService { get; set; } = null!;

        public IEnumerable<Question> Questions { get; set; } = new List<Question>();

        public Answer? Answer { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Questions = await CallBackService.GetAllQuestions();
        }

        public async Task GetAnswer(int id)
        {
            Answer = await CallBackService.GetAnswer(id);
        }
    }
}
