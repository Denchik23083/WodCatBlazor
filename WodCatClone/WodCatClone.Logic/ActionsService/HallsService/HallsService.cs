using System;
using System.Collections.Generic;
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

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _repository.GetAllHallEmblem();
        }

        public Halls GetHall(int hallId)
        {
            var hall = _repository.GetHall(hallId);

            hall.Type = hall.Type.Trim().Replace("\r", string.Empty);
            hall.Type = hall.Type.Trim().Replace("\n", string.Empty);
            hall.Type = hall.Type.Replace(Environment.NewLine, string.Empty);

            return hall;
        }

        public Halls GetHall(int? hallId)
        {
            return _repository.GetHall(hallId);
        }

        public string GetImage(int? imageId)
        {
            var hallEmblem = _repository.GetImage(imageId);

            return hallEmblem?.Image;
        }

        public bool AddHall(Halls hall)
        {
            return _repository.AddHall(hall);
        }

        public bool EditHall(Halls hall, int hallId)
        {
            return _repository.EditHall(hall, hallId);
        }

        public bool RemoveHall(int hallId)
        {
            return _repository.RemoveHall(hallId);
        }

        public void AddAthlete(int hallId)
        {
            _repository.AddAthlete(hallId);
        }

        public void RemoveAthlete(int hallId)
        {
            _repository.RemoveAthlete(hallId);
        }
    }
}
