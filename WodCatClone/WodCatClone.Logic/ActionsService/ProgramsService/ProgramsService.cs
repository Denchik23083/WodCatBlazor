using System.Collections.Generic;
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

        public IEnumerable<Programs> GetAllPrograms()
        {
            return _repository.GetAllPrograms();
        }

        public IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id)
        {
            return _repository.GetAllProgramsWorkouts(id);
        }

        public IEnumerable<User> GetAllProgramsUsers(int id)
        {
            return _repository.GetAllProgramsUsers(id);
        }

        public ProgramTimeUser GetProgramTimeUser(int programId, User user)
        {
            return _repository.GetProgramTimeUser(programId, user);
        }

        public Programs GetProgram(int id)
        {
            return _repository.GetProgram(id);
        }

        public Programs GetProgram(int? id)
        {
            return _repository.GetProgram(id);
        }

        public string GetImage(int? programsEmblemId)
        {
            var program = _repository.GetImage(programsEmblemId);

            return program.Image;
        }

        public bool BeginProgram(int id, User user)
        {
            AuthService.AuthService.User.ProgramId = id;

            return _repository.BeginProgram(id, user);
        }

        public bool StopProgram(int id, User user, bool isFinish)
        {
            AuthService.AuthService.User.ProgramId = null;

            return _repository.StopProgram(id, user, isFinish);
        }

        public int Subscribers(int programId)
        {
            var users = _userRepository.GetAllUsers();
            return _repository.Subscribers(users, programId);
        }
    }
}
