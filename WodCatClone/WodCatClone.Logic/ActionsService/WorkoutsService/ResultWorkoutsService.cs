﻿using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public class ResultWorkoutsService : IResultWorkoutsService
    {
        private readonly IResultWorkoutsRepository _repository;

        public ResultWorkoutsService(IResultWorkoutsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id)
        {
            return _repository.GetAllResultWorkouts(id);
        }

        public ResultWorkouts GetResultWorkouts(int id)
        {
            return _repository.GetResultWorkouts(id);
        }

        public int GetCountResultWorkouts(int id)
        {
            return _repository.GetCountResultWorkouts(id);
        }

        public bool AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            return _repository.AddResultWorkouts(resultWorkouts);
        }

        public bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            return _repository.EditResultWorkouts(resultWorkouts, id);
        }

        public bool DeleteResultWorkouts(int id)
        {
            return _repository.DeleteResultWorkouts(id);
        }
    }
}