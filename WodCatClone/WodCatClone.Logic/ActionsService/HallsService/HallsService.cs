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
            return _repository.GetHall(hallId);
        }

        public string GetImage(int imageId)
        {
            var hallEmblem = _repository.GetImage(imageId);

            return hallEmblem.Image;
        }

        public bool AddHall(Halls hall)
        {
            return _repository.AddHall(hall);
        }
    }
}
