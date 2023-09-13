using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.MorePage
{
    public partial class CallBackPage
    {
        [Inject] public ICallBackService CallBackService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public IEnumerable<Question> Questions { get; set; } = new List<Question>();

        public Answer? Answer { get; set; } = new();

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();
            Questions = await CallBackService.GetAllQuestionsAsync();
        }

        public async Task GetAnswer(int id)
        {
            Answer = await CallBackService.GetAnswerAsync(id);
        }
    }
}
