using System;
using System.Collections.Generic;
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

        public ProgramTimeUser GetProgramTimeUser(int programId, User user)
        {
            return _context.ProgramTimeUser.FirstOrDefault(b => b.ProgramsId == programId && b.UserId == user.Id);
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

            var programTimeUser = _context.ProgramTimeUser.FirstOrDefault(b => b.UserId == user.Id);

            if (programTimeUser is not null)
            {
                _context.ProgramTimeUser.Remove(programTimeUser);
            }

            var newProgramTimeUser = new ProgramTimeUser
            {
                BeginProgramDate = DateTime.Now,
                ProgramsId = id,
                UserId = user.Id
            };

            _context.ProgramTimeUser.Add(newProgramTimeUser);
            _context.SaveChanges();

            return true;
        }

        public bool StopProgram(int id, User user, bool isFinish)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.ProgramId = null;

            var programTimeUser = _context.ProgramTimeUser.FirstOrDefault(b => b.ProgramsId == id && b.UserId == user.Id);

            if (programTimeUser is null)
            {
                return false;
            }

            _context.ProgramTimeUser.Remove(programTimeUser);

            if (isFinish)
            {
                loginUser.Points += 50;
            }

            _context.SaveChanges();

            return true;
        }

        public int Subscribers(int programId)
        {
            return _context.Users.Count(b => b.ProgramId == programId);
        }
    }
}
