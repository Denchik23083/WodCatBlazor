using System.Collections.Generic;
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

        protected override void OnInitialized()
        {
            Questions = CallBackService.GetAllQuestions();
        }

        public void GetAnswer(int id)
        {
            Answer = CallBackService.GetAnswer(id);
        }
    }
}
