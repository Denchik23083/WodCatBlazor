using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;

namespace WodCatClone.Web.Pages.MorePage
{
    public partial class CallBackPage
    {
        [Inject] public ICallBackService CallBackService { get; set; }

        public IEnumerable<Question> Questions { get; set; }

        public Answer Answer { get; set; }

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
