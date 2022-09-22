using System;
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
            return _repository.GetImage(programsEmblemId)?.Image;
        }

        public bool BeginProgram(int id, User user)
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

            var programTimeUser = _repository.GetProgramTimeUser(id, loginUser);

            return _repository.BeginProgram(id, loginUser, programTimeUser, newProgramTimeUser);
        }

        public bool StopProgram(int id, User user, bool isFinish)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            var programTimeUser = _repository.GetProgramTimeUser(id, loginUser);

            if (programTimeUser is null)
            {
                return false;
            }

            return _repository.StopProgram(id, loginUser, programTimeUser, isFinish);
        }

        public int Subscribers(int programId)
        {
            return _repository.Subscribers(programId);
        }
    }
}
