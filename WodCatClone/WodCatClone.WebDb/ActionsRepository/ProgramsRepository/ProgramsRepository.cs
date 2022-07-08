﻿using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public class ProgramsRepository : IProgramsRepository
    {
        private readonly WodCatCloneContext _context;

        public ProgramsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Programs> GetAllPrograms()
        {
            return _context.Programs;
        }

        public IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id)
        {
            return _context.ProgramsWorkouts.Where(b => b.ProgramsId == id);
        }

        public IEnumerable<User> GetAllProgramsUsers(int id)
        {
            return _context.Users.Where(b => b.ProgramId == id);
        }

        public Programs GetProgram(int id)
        {
            return _context.Programs.FirstOrDefault(b => b.Id == id);
        }

        public Programs GetProgram(int? id)
        {
            return _context.Programs.FirstOrDefault(b => b.Id == id);
        }

        public ProgramEmblem GetImage(int? programsEmblemId)
        {
            return _context.ProgramEmblem.FirstOrDefault(b => b.Id == programsEmblemId);
        }

        public bool BeginProgram(int id, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.ProgramId = id;

            _context.SaveChanges();

            return true;
        }

        public bool StopProgram(int id, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.ProgramId = null;

            _context.SaveChanges();

            return true;
        }

        public int Subscribers(IEnumerable<User> users, int programId)
        {
            var programUsers = users.Count(b => b.ProgramId == programId);

            return programUsers;
        }
    }
}
