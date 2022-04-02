﻿using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public class HallsService : IHallsService
    {
        private readonly IHallsRepository _repository;

        public HallsService(IHallsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Halls> GetAllHalls()
        {
            return _repository.GetAllHalls();
        }
    }
}
