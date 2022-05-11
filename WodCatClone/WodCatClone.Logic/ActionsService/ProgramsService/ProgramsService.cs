using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
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

        public Programs GetProgram(int id)
        {
            return _repository.GetProgram(id);
        }
    }
}
