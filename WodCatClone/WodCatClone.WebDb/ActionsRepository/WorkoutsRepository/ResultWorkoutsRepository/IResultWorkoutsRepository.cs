﻿using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.ResultWorkoutsRepository
{
    public interface IResultWorkoutsRepository
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        ResultWorkouts GetResultWorkout(int id);

        bool AddResultWorkouts(ResultWorkouts resultWorkouts, User user);

        bool EditResultWorkouts(ResultWorkouts resultWorkouts, ResultWorkouts resultWorkoutEdit, User user);

        bool DeleteResultWorkouts(ResultWorkouts resultWorkoutRemove);
    }
}