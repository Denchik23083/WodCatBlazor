using System;
using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public class HallsService : IHallsService
    {
        private readonly IHallsRepository _repository;
        private readonly IUserRepository _userRepository;

        public HallsService(IHallsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public IEnumerable<Halls> GetAllHalls()
        {
            return _repository.GetAllHalls();
        }

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _repository.GetAllHallEmblem();
        }

        public IEnumerable<User> GetAllHallsUsers(int id)
        {
            return _repository.GetAllHallsUsers(id);
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

        public int Athlete(int hallId)
        {
            var users = _userRepository.GetAllUsers();
            return _repository.Athlete(users, hallId);
        }
    }
}
