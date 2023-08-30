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

        public async Task<IEnumerable<Programs>> GetAllPrograms()
        {
            return await _repository.GetAllPrograms();
        }

        public async Task<ProgramTimeUser?> GetProgramTimeUser(int programId, User user)
        {
            return await _repository.GetProgramTimeUser(programId, user);
        }

        public async Task<Programs?> GetProgram(int id)
        {
            return await _repository.GetProgram(id);
        }

        public async Task<bool> BeginProgram(int id, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

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

            var programTimeUser = await _repository.GetProgramTimeUser(id, loginUser);

            loginUser.ProgramId = id;

            return await _repository.BeginProgram(id, loginUser, programTimeUser, newProgramTimeUser);
        }

        public async Task<bool> StopProgram(int id, User user, bool isFinish)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            var programTimeUser = await _repository.GetProgramTimeUser(id, loginUser);

            if (programTimeUser is null)
            {
                return false;
            }

            loginUser.ProgramId = null;

            return await _repository.StopProgram(id, loginUser, programTimeUser, isFinish);
        }
    }
}
