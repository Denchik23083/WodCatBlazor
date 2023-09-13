using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public class ProgramsService : IProgramsService
    {
        private readonly IProgramsRepository _repository;
        private readonly IUserRepository _userRepository;

        public ProgramsService(IProgramsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Programs>> GetAllProgramsAsync()
        {
            return await _repository.GetAllProgramsAsync();
        }

        public async Task<Programs?> GetProgramAsync(int id)
        {
            return await _repository.GetProgramAsync(id);
        }

        public async Task<bool> BeginProgramAsync(int id, User user)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            var newProgramTimeUser = new ProgramTimeUser
            {
                BeginProgramDate = DateTime.Now,
                ProgramsId = id,
                UserId = loginUser.Id
            };

            var programTimeUser = loginUser.ProgramTimeUsers?.FirstOrDefault(_ => _.ProgramsId == id);

            loginUser.ProgramId = id;

            return await _repository.BeginProgramAsync(loginUser, programTimeUser, newProgramTimeUser);
        }

        public async Task<bool> StopProgramAsync(int id, User user, bool isFinish)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            var programTimeUser = loginUser.ProgramTimeUsers?.FirstOrDefault(_ => _.ProgramsId == id);
            
            loginUser.ProgramId = null;

            return await _repository.StopProgramAsync(loginUser, programTimeUser, isFinish);
        }
    }
}
