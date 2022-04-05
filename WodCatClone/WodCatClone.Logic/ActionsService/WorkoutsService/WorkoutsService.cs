using System;
using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public class WorkoutsService : IWorkoutsService
    {
        private readonly IWorkoutsRepository _repository;

        public WorkoutsService(IWorkoutsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Workouts> GetAllWorkouts()
        {
            return _repository.GetAllWorkouts();
        }

        public Workouts GetWorkout(int workoutId)
        {
            return _repository.GetWorkout(workoutId);
        }

        public string GetImage(int imageId)
        {
            var hallEmblem = _repository.GetImage(imageId);

            return hallEmblem.Image;
        }
    }
}
