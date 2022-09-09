using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Halls>> GetAllHalls()
        {
            return await _repository.GetAllHalls();
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

            return hall;
        }

        public async Task<Halls> GetHall(int? hallId)
        {
            return await _repository.GetHall(hallId);
        }

        public async Task<string> GetImage(int? imageId)
        {
            var hallEmblem = await _repository.GetImage(imageId);

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

        public bool JoinHall(int hallId, User user)
        {
            AuthService.AuthService.User.HallId = hallId;

            return _repository.JoinHall(hallId, user);
        }

        public bool ExitHall(int hallId, User user)
        {
            AuthService.AuthService.User.HallId = null;

            return _repository.ExitHall(hallId, user);
        }

        public int Athlete(int hallId)
        {
            var users = _userRepository.GetAllUsers();
            return _repository.Athlete(users, hallId);
        }
    }
}
