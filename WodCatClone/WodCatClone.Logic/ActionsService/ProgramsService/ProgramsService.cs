using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public class ProgramsService : IProgramsService
    {
        private readonly IProgramsRepository _repository;

        public ProgramsService(IProgramsRepository repository)
        {
            _repository = repository;
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

        public Programs GetProgram(int id)
        {
            return _repository.GetProgram(id);
        }

        public bool BeginProgram(int id, User user)
        {
            AuthService.AuthService.User.ProgramsId = id;

            return _repository.BeginProgram(id, user);
        }

        public bool StopProgram(int id, User user)
        {
            AuthService.AuthService.User.ProgramsId = null;

            return _repository.StopProgram(id, user);
        }
    }
}
