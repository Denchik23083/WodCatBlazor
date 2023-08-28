﻿using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.WorkoutsRepository
{
    public class WorkoutsRepository : IWorkoutsRepository
    {
        private readonly WodCatCloneContext _context;

        public WorkoutsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Workouts>> GetAllWorkouts()
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .Include(_ => _.ResultWorkouts)
                .ToListAsync();
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id)
        {
            return _context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id)
        {
            return _context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
        }

        public async Task<Workouts?> GetWorkout(int workoutId)
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.ResultWorkouts)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .FirstOrDefaultAsync(_ => _.Id == workoutId);
        }

        public Workouts GetWorkout(int? workoutId)
        {
            return _context.Workouts.FirstOrDefault(x => x.Id == workoutId);
        }
    }
}
