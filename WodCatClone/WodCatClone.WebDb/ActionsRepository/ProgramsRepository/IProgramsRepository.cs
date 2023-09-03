﻿using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        Task<IEnumerable<Programs>> GetAllPrograms();

        Task<Programs?> GetProgram(int id);

        Task<bool> BeginProgram(User loginUser, ProgramTimeUser? programTimeUser, ProgramTimeUser newProgramTimeUser);

        Task<bool> StopProgram(User loginUser, ProgramTimeUser? programTimeUser, bool isFinish);
    }
}
